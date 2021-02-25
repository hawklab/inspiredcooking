using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using recipes.Core;
using recipes.Data;

namespace recipes.Pages.Ingredients
{
    public class DeleteModel : PageModel
    {
        private readonly IIngredientData ingredientData;

        public Ingredient Ingredient { get; set; }
        public DeleteModel(IIngredientData ingredientData)
        {
            this.ingredientData = ingredientData;
        }
        public IActionResult OnGet(int ingredientId)
        {
            Ingredient = ingredientData.GetById(ingredientId);
            if (Ingredient == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost(int ingredientId)
        {
            var ingredient = ingredientData.Delete(ingredientId);
            ingredientData.Commit();

            if (ingredient == null)
            {
                return RedirectToPage("./NotFound");
            }
            return RedirectToPage("./List");
        }
    }
}
