class Recipe
  include Mongoid::Document
  include Mongoid::Timestamps
  include Mongoid::Slug

  field :name, type: String
  field :description, type: String
  field :photo, type: String
  field :preptime, type: String
  field :cooktime, type: String
  field :servings, type: String
  field :difficulty, type: String
  field :cuisine, type: String


  slug :name, history: true

  embeds_many :steps
  has_and_belongs_to_many :favorited_by, class_name: 'User', inverse_of: :favorite_recipes

end
