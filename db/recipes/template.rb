# frozen_string_literal: true

Recipe.create(
  {
    name: 'name',
    description: <<-END_OF_DESCRIPTION,
    description

    END_OF_DESCRIPTION
    preptime: 5,
    cooktime: 5,
    servings: 2,
    steps: [
      {
        instructions: <<-END_OF_INSTRUCTIONS,
        instructions
        END_OF_INSTRUCTIONS
        ingredients: [
          {
            id: 'ingredient',
            quantity: [2, 'g']
          }
        ]
      }
    ],
    cuisines: []
  }
)
