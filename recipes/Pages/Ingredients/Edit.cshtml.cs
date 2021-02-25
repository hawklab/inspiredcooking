using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using recipes.Data;
using recipes.Core;

namespace recipes.Pages.Ingredients
{
    public class EditModel : PageModel
    {
        private readonly IIngredientData ingredientData;

        [BindProperty]
        public Ingredient Ingredient { get; set; }

        public EditModel(IIngredientData ingredientData)
        {
            this.ingredientData = ingredientData;
        }
        public IActionResult OnGet(int? ingredientId)
        {
            if (ingredientId.HasValue)
            {
                Ingredient = ingredientData.GetById(ingredientId.Value);
            }
            else
            {
                Ingredient = new Ingredient();
            }

            if (Ingredient == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
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
                Ingredient.RecipeId = 3;
                ingredientData.Add(Ingredient);
                
            }
            ingredientData.Commit();
            return RedirectToPage("./Detail", new { IngredientId = Ingredient.Id });
        }
    }
}
