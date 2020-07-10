class StepsController < ApplicationController


  def show
    @step_number = params[:id].to_i
    @recipe = Recipe.find(params[:recipe_id])
    @step = @recipe.steps[@step_number-1]
  end


end
