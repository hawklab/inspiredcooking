# frozen_string_literal: true

require 'rails_helper'

RSpec.describe Ingredient, type: :model do
  FLOUR_100GRAMS = Ingredient.new('flour', nil, QuantityField.new(100, 'grams'))
  OTHER_1LITER = Ingredient.new(nil, 'Some uncommon ingredient', QuantityField.new(1, 'liter'))

  context 'base attributes' do
    it 'has a name' do
      expect(FLOUR_100GRAMS.name).to eq('Flour')
      expect(OTHER_1LITER.name).to eq('Some uncommon ingredient')
    end
  end
end
