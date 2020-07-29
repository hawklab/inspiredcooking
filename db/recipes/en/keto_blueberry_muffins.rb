# frozen_string_literal: true

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
  cuisines: ["german"]
})
