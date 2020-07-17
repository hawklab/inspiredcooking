# frozen_string_literal: true

Recipe.create(
  {
    name: 'Kaleprese Salad',
    description: <<-END_OF_DESCRIPTION,
    This is a simple twist on the traditional Caprese salad.
    Swapping the Basil with fresh Kale gives it a more earty flavor along with a more crunchy texture.
    END_OF_DESCRIPTION
    preptime: 15,
    cooktime: 15,
    servings: 4,
    steps: [
      {
        instructions: <<-END_OF_INSTRUCTIONS,
        Slice your tomatoes and chop your mozzarella cheese and Kale leaves
        END_OF_INSTRUCTIONS
        ingredients: [
          {
            id: 'tomato',
            quantity: [4, 'unit']
          },
          {
            id: 'cheese-mozzarella',
            quantity: [200, 'gram']
          },
          {
            id: 'kale-leaves',
            quantity: [3, 'unit']
          }
        ]
      },
      {
        instructions: <<-END_OF_INSTRUCTIONS,
        Mix all your ingredients and season with olive oil and and salt
        END_OF_INSTRUCTIONS
        ingredients: [
          {
            id: 'oil-olive',
            quantity: [20, 'gr']
          },
          {
            id: 'salt',
            quantity: [1, 'pinch']
          }
        ]
      }
    ],
    cuisines: ['italian']
  }
)
