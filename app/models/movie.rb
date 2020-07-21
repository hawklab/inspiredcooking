class Movie
  include Mongoid::Document
  include Mongoid::Timestamps
  field :name, type: String
  field :storyline, type: String
end
