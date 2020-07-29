Rails.application.routes.draw do
  resources :movies
  devise_for :users, controllers: {
    sessions: 'users/sessions'
  }
  resources :recipes do
    resources :steps
    member do
      post 'favorite'
      delete 'favorite', action: "unfavorite"
    end
  end

  resources :users

  root to: "recipes#index"

  # For details on the DSL available within this file, see https://guides.rubyonrails.org/routing.html
end
