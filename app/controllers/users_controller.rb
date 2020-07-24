# frozen_string_literal: true

class UsersController < ApplicationController
  before_action :set_user, only: %i[show edit update]
  # GET
  def show
    if @user != current_user
      redirect_to recipes_path
    end
  end

  # GET /users/:id/edit
  def edit
    if @user != current_user
      redirect_to recipes_path
    end
  end

  # PATCH/PUT /users/:id
  def update
    if @user != current_user
      redirect_to recipes_path
    end
    respond_to do |format|
      if @user.update(user_params)
        format.html { redirect_to @user, notice: 'Your information was successfully updated.' }
      else
        format.html { render :edit }
      end
    end
  end

  private

  # Use callbacks to share common setup or constraints between actions.
  def set_user
    @user = User.find(params[:id])
  end

  # Only allow a list of trusted parameters through.
  def user_params
    params.require(:user).permit(:name, :email)
  end
end
