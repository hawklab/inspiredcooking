# frozen_string_literal: true

Recipe.create({
  name: "Guatitas a la Jardinera",
  description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
  preptime: "45 minutes",
  cooktime: "30 minutes",
  servings: "4 ",
  steps: [
    {
      instructions: "Paso 1",
      ingredients: [
        {
          id: "flour",
          quantity: [500, "grams"]
        }
      ]
    },
    {
      instructions: "Paso 2",
      ingredients: [
        {
          id: "flour",
          quantity: [100, "grams"]
        }
      ]
    },
    {
      instructions: "Paso 3",
      ingredients: [
        {
          id: "sugar",
          quantity: [100, "grams"]
        }
      ]
    },
    {
      instructions: "Paso 4",
      ingredients: []
    }
  ],
  cuisines: ["french"]
})
