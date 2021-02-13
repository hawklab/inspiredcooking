using System.Collections.Generic;
using recipes.Core;
using System.Linq;

namespace recipes.Data
{
    public interface IRecipeData
    {
        IEnumerable<Recipe> GetRecipesByName(string name);
    }

    public class InMemoryRecipeData : IRecipeData
    {
        List<Recipe> recipes;
        public InMemoryRecipeData()
        {
            recipes = new List<Recipe>()
            {
                new Recipe { Id = 1, Name = "Pastel de Choclo", Description = "El favorito de Seba", Photo = "Photo Pending", PrepTime = "2 hours", CookTime = "20 minutes", Servings = 6, Difficulty = 3, Cuisine=Recipe.CuisineType.Chilean },
                new Recipe { Id = 2, Name = "Pollo Arvejado", Description = "Receta del Primo!", Photo = "Photo Pending", PrepTime = "20 minutes", CookTime = "1 hour", Servings = 6, Difficulty = 2, Cuisine=Recipe.CuisineType.Chilean },
                new Recipe { Id = 2, Name = "Guatitas a la Jardinera", Description = "El favorito de Carito", Photo = "Photo Pending", PrepTime = "20 minutes", CookTime = "1 hour", Servings = 6, Difficulty = 2, Cuisine=Recipe.CuisineType.Chilean }
            };
        }

        public IEnumerable<Recipe> GetRecipesByName(string name = null)
        {
            return from r in recipes
                    where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                    orderby r.Name
                    select r;
        }
    }

}