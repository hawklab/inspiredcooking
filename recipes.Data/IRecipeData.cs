using System.Collections.Generic;
using recipes.Core;

namespace recipes.Data
{
    public interface IRecipeData
    {
        IEnumerable<Recipe> GetRecipesByName(string name);
        Recipe GetById(int id);
        Recipe Update(Recipe updatedRecipe);
        Recipe Add(Recipe newRecipe);
        Recipe Delete(int id);
        int Commit();

    }
}