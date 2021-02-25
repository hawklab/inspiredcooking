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
    public class DetailModel : PageModel
    {
        private readonly IIngredientData ingredientData;

        public Ingredient Ingredient { get; set; }

        public DetailModel(IIngredientData ingredientData)
        {
            this.ingredientData = ingredientData;
        }

        public IActionResult OnGet(int IngredientId)
        {
            Ingredient = ingredientData.GetById(IngredientId);
            if (Ingredient == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}


