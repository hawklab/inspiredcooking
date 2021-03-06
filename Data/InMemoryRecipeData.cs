﻿using System.Collections.Generic;
using InspiredCooking.Core;
using System.Linq;

namespace InspiredCooking.Data
{
    public class InMemoryRecipeData : IRecipeData
    {
        List<Recipe> recipes;
        public InMemoryRecipeData()
        {
            recipes = new List<Recipe>()
            {
                new Recipe { Id = 1, Name = "Pastel de Choclo", Description = "El favorito de Seba",  PrepTime = "2 hours", CookTime = "20 minutes", Servings = 6, Cuisine=Recipe.CuisineType.Chilean },
                new Recipe { Id = 2, Name = "Pollo Arvejado", Description = "Receta del Primo!",  PrepTime = "20 minutes", CookTime = "1 hour", Servings = 6, Cuisine=Recipe.CuisineType.Chilean },
                new Recipe { Id = 3, Name = "Guatitas a la Jardinera", Description = "El favorito de Carito", PrepTime = "20 minutes", CookTime = "1 hour", Servings = 6, Cuisine=Recipe.CuisineType.Chilean }
            };
        }

        public Recipe GetById(int id)
        {
            return recipes.SingleOrDefault(r => r.Id == id);
        }

        public Recipe Add(Recipe newRecipe)
        {
            recipes.Add(newRecipe);
            newRecipe.Id = recipes.Max(r => r.Id) + 1;
            return newRecipe;
        }

        public Recipe Update(Recipe updatedRecipe)
        {
            var recipe = recipes.SingleOrDefault(r => r.Id == updatedRecipe.Id);
            if (recipe != null)
            {
                recipe.Name = updatedRecipe.Name;
                recipe.Description = updatedRecipe.Description;
                recipe.PrepTime = updatedRecipe.PrepTime;
                recipe.CookTime = updatedRecipe.CookTime;
                recipe.Servings = updatedRecipe.Servings;
                recipe.Difficulty = updatedRecipe.Difficulty;
                recipe.Cuisine = updatedRecipe.Cuisine;
            }
            return recipe;
        }

        public int Commit()
        {
            return 0;
        }
        public IEnumerable<Recipe> GetRecipesByName(string name = null)
        {
            return from r in recipes
                    where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                    orderby r.Name
                    select r;
        }

        public Recipe Delete(int id)
        {
            var recipe = recipes.FirstOrDefault(r => r.Id == id);
            if(recipe != null)
            {
                recipes.Remove(recipe);
            }
            return recipe;
        }

        public int GetCountOfRecipes()
        {
            return recipes.Count();
        }

        public IEnumerable<Recipe> GetRecipesByIds(IEnumerable<int> ids)
        {
            throw new System.NotImplementedException();
        }
    }

}