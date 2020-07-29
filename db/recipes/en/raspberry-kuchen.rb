# frozen_string_literal: true

Recipe.create(
  {
    name: 'raspberry Kuchen',
    description: <<-END_OF_DESCRIPTION,
    This pie is a delight! A simple and forgiving recipe for those who are not used to bake.
    Feel free to experiment changing this recipe to your taste too, change the berries or the spices to get different flavors or to accomodate to what you have on your pantry.
    END_OF_DESCRIPTION
    preptime: 15,
    cooktime: 85,
    servings: 12,
    steps: [
      {
        instructions: <<-END_OF_INSTRUCTIONS,
        Pre-Heat your oven at 350F
        END_OF_INSTRUCTIONS
      },
      {
        instructions: <<-END_OF_INSTRUCTIONS,
        Mix all these ingredients and break appart with a fork to get a crumbly texture and set aside.
        END_OF_INSTRUCTIONS
        ingredients: [
          {
            id: 'flour',
            quantity: [0.5, 'cup']
          },
          {
            id: 'butter',
            quantity: [0.25, 'cup'],
            notes: 'melted'
          },
          {
            id: 'sugar',
            quantity: [0.5, 'cup']
          }
        ]
      },
      {
        instructions: <<-END_OF_INSTRUCTIONS,
        Mix all the dry ingredients first, then incorporate the milk, butter, egg and vanilla.
        Beat for 2 minutes or until they are well blended.
        END_OF_INSTRUCTIONS
        ingredients: [
          {
            id: 'flour',
            quantity: [1.5, 'cup']
          },
          {
            id: 'butter',
            quantity: [0.25, 'cup']
          },
          {
            id: 'sugar',
            quantity: [0.5, 'cup']
          },
          {
            id: 'bakingpowder',
            quantity: [1, 'tspn']
          },
          {
            id: 'lemon-zest',
            quantity: [1.5, 'tspn'],
            optional: true
          },
          {
            id: 'nutmeg-ground',
            quantity: [0.5, 'tspn'],
            optional: true
          },
          {
            id: 'salt',
            quantity: [0.25, 'tspn']
          },
          {
            id: 'milk',
            quantity: [0.666, 'cup']
          },
          {
            id: 'egg',
            quantity: [1, 'unit'],
            notes: 'at room temperature, beaten'
          },
          {
            id: 'vanilla-extract',
            quantity: [1, 'tspn']
          }
        ]
      },
      {
        instructions: <<-END_OF_INSTRUCTIONS,
        Pour the mixture into a greased baking dish. Sprinkle your berries and the crumbly mixture from the first step
        END_OF_INSTRUCTIONS
        ingredients: [
          {
            id: 'raspberry',
            quantity: [2, 'cup'],
            notes: 'fresh or frozen, can be mixed/changed for other berries too'
          }
        ]
      },
      {
        instructions: <<-END_OF_INSTRUCTIONS,
        Bake for 40 minutes or until lightly browned and let it rest for another 30 minutes before serving.
        END_OF_INSTRUCTIONS
      }
    ],
    cuisines: ['german']
  }
)
