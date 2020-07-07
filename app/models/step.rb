class Step
  include Mongoid::Document

  field :instructions, type: String
  field :ingredients # No type for now, will create a custom type later.

  embedded_in :recipe
end
