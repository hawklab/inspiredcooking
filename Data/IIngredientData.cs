using System.Collections.Generic;
using InspiredCooking.Core;

namespace InspiredCooking.Data
{
    public interface IIngredientData
    {
        IEnumerable<Ingredient> GetIngredientsByName(string name);
        Ingredient GetById(int id);
        Ingredient Update(Ingredient updatedIngredient);
        Ingredient Add(Ingredient newIngredient);
        Ingredient Delete(int id);
        int GetCountOfIngredients();
        int Commit();

    }
}