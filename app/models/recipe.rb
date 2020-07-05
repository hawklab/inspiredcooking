class Recipe
  include Mongoid::Document
  include Mongoid::Timestamps

  field :name, type: String
  field :description, type: String
  field :photo, type: String

  embeds_many :steps
end
