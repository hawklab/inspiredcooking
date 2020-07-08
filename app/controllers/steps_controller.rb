class StepsController < ApplicationController


  def show
    @recipe = Recipe.find(params[:recipe_id])
    @step = @recipe.steps[params[:id].to_i-1]
  end


end
