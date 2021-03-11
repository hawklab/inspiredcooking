using System.Collections.Generic;
using InspiredCooking.Core;

namespace InspiredCooking.Data
{
    public interface IRecipeData
    {
        IEnumerable<Recipe> GetRecipesByName(string name);
        IEnumerable<Recipe> GetRecipesByIds(IEnumerable<int> ids);
        Recipe GetById(int id);
        Recipe Update(Recipe updatedRecipe);
        Recipe Add(Recipe newRecipe);
        Recipe Delete(int id);
        int GetCountOfRecipes();
        int Commit();

    }
}