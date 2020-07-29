# frozen_string_literal: true

Recipe.create(
  {
    name: 'Tomatoes & Oregano salad',
    description: <<-END_OF_DESCRIPTION,
    This simple salad is ready in just a couple minutes and has pulled me out of a stretch multiple times.

    It's intense flavor and aroma makes it one of my favorite side dishes for a Steak
    END_OF_DESCRIPTION
    preptime: 5,
    cooktime: 5,
    servings: 2,
    steps: [
      {
        instructions: <<-END_OF_INSTRUCTIONS,
        Chop your tomatoes in wedges (slices work too)
        END_OF_INSTRUCTIONS
        ingredients: [
          {
            id: 'tomato',
            quantity: [2, 'unit']
          }
        ]
      },
      {
        instructions: <<-END_OF_INSTRUCTIONS,
        Season your tomatoes with a generous amount of oregano and olive oil and a pinch of salt
        END_OF_INSTRUCTIONS
        ingredients: [
          {
            id: 'oregano-dry',
            quantity: [2, 'gr']
          },
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
    cuisines: ['chilean']
  }
)
