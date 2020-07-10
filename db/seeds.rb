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
  cuisine: "French"
})

Recipe.create({
  name: "Pollo Arverjado",
  description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
  preptime: "30 minutes",
  cooktime: "40 minutes",
  servings: "2",
  steps: [
    {
      instructions: "Paso 1",
      ingredients: []
    },
    {
      instructions: "Paso 2",
      ingredients: []
    },
    {
      instructions: "Paso 3",
      ingredients: []
    }
  ],
  cuisine: "Chilean"
})

Recipe.create({
  name: "Keto Blueberry Muffins",
  description: "Mornings are busy in our house, so I love to have grab and go options on hand! These keto-friendly blueberry muffins are delish, and perfect for a quick and easy breakfast!",
  preptime: "10 minutes",
  cooktime: "15 minutes",
  servings: "10",
  steps: [
    {
      instructions: "Place the almond flour, coconut flour, sweetener, baking powder, and salt in a medium-large microwave-safe mug and blend with a fork.
      Add the egg, butter, avocado oil, and vanilla; mix well.",
      ingredients: [
        {
          id: "flour",
          quantity: [500, "grams"]
        },
        {
          id: "flour",
          quantity: [500, "grams"]
        },
        {
          id: "flour",
          quantity: [500, "grams"]
        }
      ]
    },
    {
      instructions: "Gently stir in the blueberries. Use the back of a spoon to press the batter down and smooth the top.",
      ingredients: []
    },
    {
      instructions: "Place the batter-filled mug in the microwave and heat for 1 minute 15 seconds. (The cooking time may vary depending on your microwave. If the muffin is not fully formed after 1 minute 15 seconds, continue cooking in 15-second increments.) Carefully remove the mug from the microwave—it will be hot—flip it upside down over a plate, and allow the muffin to slide out of the mug onto the plate. Place the muffin on its side and slice in half. Spread with butter, if desired, and enjoy!",
      ingredients: []
    }
  ],
  cuisine: "German"
})

