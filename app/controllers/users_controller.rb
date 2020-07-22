class UsersController < ApplicationController
  before_action :set_user, only: [:show, :edit, :update]
  # GET
  def show
  end

 # GET /users/:id/edit
 def edit
 end

# PATCH/PUT /movies/1
#   PATCH/PUT /movies/1.json
  def update
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
