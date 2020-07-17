# frozen_string_literal: true

# We load all the recipes from the recipes folder
Dir[File.join(File.dirname(__FILE__), 'recipes', '*', '*.rb')].sort.each do |file|
  require file
end
