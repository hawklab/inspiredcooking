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
    @recipe.favorited_by = [current_user]
    redirect_to recipe_path(@recipe), notice:"You just add this recipe to your favorites"
  end

  def unfavorite
    @recipe = Recipe.find(params[:id])
    @recipe.favorited_by = []
    redirect_to recipe_path(@recipe), notice:"unfavorite"

  end



end
