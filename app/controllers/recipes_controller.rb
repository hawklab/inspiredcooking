class RecipesController < ApplicationController
  # before_filter :authenticate_user!, :except => [:index, :show]

  def index
    @recipes = Recipe.all
  end

  def show
    @recipe = Recipe.find(params[:id])



  end

  def favorite
    @recipe = Recipe.find(params[:id])
    if user_signed_in?
    # @recipe.favorited_by = [current_user]
    @recipe.push(favorited_by_ids: current_user.id)
    current_user.push(favorite_recipe_ids: @recipe.id)
    redirect_to recipe_path(@recipe), notice:"You just add this recipe to your favorites"
    else
      redirect_to recipe_path(@recipe), notice:"If you want to add this recipe to your favorite recipies you need to be #{view_context.link_to "logged in", new_user_session_path}"
    end
  end

  def unfavorite
    @recipe = Recipe.find(params[:id])
    # @recipe.favorited_by = []
    @recipe.pull(favorited_by_ids: current_user.id)
    current_user.pull(favorite_recipe_ids: @recipe.id)
    redirect_to recipe_path(@recipe), notice: @recipe.name + " was remove from your favorites."

  end

end
