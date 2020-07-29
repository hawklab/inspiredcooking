# frozen_string_literal: true

Recipe.create(
  {
    name: 'Chilean Salad',
    description: <<-END_OF_DESCRIPTION,
    This tomato salad is a staple of every Chilean "Asado".
    END_OF_DESCRIPTION
    preptime: 10,
    cooktime: 15,
    servings: 3,
    steps: [
      {
        instructions: <<-END_OF_INSTRUCTIONS,
        Boild the water and cut the onions in slices
        END_OF_INSTRUCTIONS
        ingredients: [
          {
            id: 'onion',
            quantity: [1, 'unit']
          },
          {
            id: 'water',
            quantity: [500, 'gr']
          }
        ]
      },
      {
        instructions: <<-END_OF_INSTRUCTIONS,
        Take the water out of the heat and drop your onion slices in it.
        Let them steep for 5 minutes.
        END_OF_INSTRUCTIONS
        ingredients: [
          {
            id: 'onion',
            quantity: [1, 'unit']
          },
          {
            id: 'water',
            quantity: [500, 'gr']
          }
        ]
      },
      {
        instructions: <<-END_OF_INSTRUCTIONS,
        Cut your tomatoes in slices while you wait for the onions.
        END_OF_INSTRUCTIONS
        ingredients: [
          {
            id: 'tomato',
            quantity: [3, 'unit']
          }
        ]
      },
      {
        instructions: <<-END_OF_INSTRUCTIONS,
        Strain your onions and let them dry a little bit.
        END_OF_INSTRUCTIONS
      },
      {
        instructions: <<-END_OF_INSTRUCTIONS,
        On a serving bowl mix your tomatoes and onions and season with olive oil and salt.
        END_OF_INSTRUCTIONS
        ingredients: [
          {
            id: 'oil-olive',
            quantity: [1, 'pinch']
          },
          {
            id: 'salt',
            quantity: [1, 'pinch']
          }
        ]
      }
    ],
    cuisines: ['chilean']
  }
)
