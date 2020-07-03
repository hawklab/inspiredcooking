class Step
  include Mongoid::Document

  field :instructions, type: String

  embedded_in :recipe
end
