# frozen_string_literal: true

# Class to tepresents an arbitrary quantity
class QuantityField
  attr_reader :amount, :unit

  def initialize(amount, unit)
    @amount = amount
    @unit = unit
  end

  def +(other)
    throw ArgumentError.new('unit mismatch') if unit != other.unit

    QuantityField.new(amount + other.amount, unit)
  end

  def *(other)
    QuantityField.new(amount * other, unit)
  end

  def ==(other)
    amount == other.amount && unit == other.unit
  end

  # MEthods to stored on the database.
  # See: https://docs.mongodb.com/mongoid/7.0/tutorials/mongoid-documents/index.html#custom-fields

  # Converts an object of this instance into a database friendly value.
  def mongoize
    [amount, unit]
  end

  class << self
    # Get the object as it was stored in the database, and instantiate
    # this custom class from it.
    def demongoize(object)
      QuantityField.new(object[0], object[1])
    end

    # Takes any possible object and converts it to how it would be
    # stored in the database.
    def mongoize(object)
      case object
      when QuantityField then object.mongoize
      else object
      end
    end
  end
end
