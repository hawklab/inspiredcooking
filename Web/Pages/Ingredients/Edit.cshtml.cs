using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InspiredCooking.Data;
using InspiredCooking.Core;

namespace InspiredCooking.Pages.Ingredients
{
    public class EditModel : PageModel
    {
        private readonly IIngredientData ingredientData;
        private readonly IRecipeData recipeData;

        [BindProperty]
        public Ingredient Ingredient { get; set; }

        public EditModel(IIngredientData ingredientData, IRecipeData recipeData)
        {
            this.ingredientData = ingredientData;
            this.recipeData = recipeData;
        }
        public IActionResult OnGet(int? ingredientId, int recipeId)
        {
            var recipe = recipeData.GetById(recipeId);

            if (ingredientId.HasValue)
            {
                Ingredient = ingredientData.GetById(ingredientId.Value);
            }
            else
            {
                Ingredient = new Ingredient();
                Ingredient.RecipeId = recipe.Id;
            }

            if (Ingredient == null)
            {
                return RedirectToPage("./NotFound");
            }
            if (Ingredient.RecipeId == recipe.Id)
            {
                return Page();
            }
            else
            {
                return RedirectToPage("/'Notfound");
            }
            return Page();
        }

        public IActionResult OnPost(int recipeId)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Ingredient.Id > 0)
            {
                ingredientData.Update(Ingredient);
            }
            else
            {
                Ingredient.RecipeId = recipeId;
                ingredientData.Add(Ingredient);
                
            }
            ingredientData.Commit();
            return RedirectToPage("./Detail", new { IngredientId = Ingredient.Id });
        }
    }
}
