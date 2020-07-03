require 'rails_helper'

# frozen_string_literal: true

RSpec.describe QuantityField, type: :model do
  QUANTITY_3CUPS = QuantityField.new(3, :cups)

  context 'Initialization' do
    it 'Values are properly assigned' do
      expect(QUANTITY_3CUPS).to_not be_nil
      expect(QUANTITY_3CUPS.amount).to be 3
      expect(QUANTITY_3CUPS.unit).to be :cups
    end
  end
end
