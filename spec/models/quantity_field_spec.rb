require 'rails_helper'

# frozen_string_literal: true

RSpec.describe QuantityField, type: :model do
  QUANTITY_1CUPS = QuantityField.new(1, :cups)
  QUANTITY_2CUPS = QuantityField.new(2, :cups)
  QUANTITY_3CUPS = QuantityField.new(3, :cups)
  QUANTITY_100GRAMS = QuantityField.new(100, :grams)

  context 'Initialization' do
    it 'Values are properly assigned' do
      expect(QUANTITY_3CUPS).to_not be_nil
      expect(QUANTITY_3CUPS.amount).to be 3
      expect(QUANTITY_3CUPS.unit).to be :cups
    end
  end

  context "simple manipulation" do
    it 'can be summed' do
      expect(QUANTITY_1CUPS + QUANTITY_2CUPS).to eq(QUANTITY_3CUPS)
    end

    it 'can be multiplied' do
      expect(QUANTITY_1CUPS * 3).to eq(QUANTITY_3CUPS)
    end

    # TODO: For Carito
    # it 'can be divided' do
    #   expect(QUANTITY_2CUPS / 2).to eq(QUANTITY_1CUPS)
    # end
  end

  context 'when units are different' do
    it 'fails to sum' do
      expect{ QUANTITY_1CUPS + QUANTITY_100GRAMS }.to raise_error
    end
  end
end
