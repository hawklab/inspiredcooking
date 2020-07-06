# frozen_string_literal: true

# To repesent a single ingredien
class Ingredient
  attr_reader :id, :quantity

  def initialize(id, name = nil, quantity = nil)
    @id = id
    @name = name
    @quantity = quantity
  end

  def name
    @name || KNOWN_INGREDIENTS.fetch(id)
  end

  def common?
    !id.nil?
  end

  def other?
    id.nil?
  end
end

# Temporary Pseudo database of ingredients
KNOWN_INGREDIENTS = {
  'flour' => 'Flour',
  'water' => 'Water'
}.freeze
