# frozen_string_literal: true

# Class to tepresents an arbitrary quantity
#
# To be Stored on the database.
# See: https://docs.mongodb.com/mongoid/7.0/tutorials/mongoid-documents/index.html#custom-fields
class QuantityField
  attr_reader :amount, :unit

  def initialize(amount, unit)
    @amount = amount
    @unit = unit
  end
end
