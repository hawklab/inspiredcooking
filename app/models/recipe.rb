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
  field :cuisines, type: Set

  slug :name, history: true

  embeds_many :steps
end
