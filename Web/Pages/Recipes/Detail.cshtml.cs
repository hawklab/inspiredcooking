using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InspiredCooking.Core;
using InspiredCooking.Data;

namespace InspiredCooking.Pages.Recipes
{
    public class DetailModel : PageModel
    {
        private readonly IRecipeData recipeData;

        [TempData]
        public string Message { get; set; }

        public Recipe Recipe { get; set; }

        public DetailModel(IRecipeData recipeData)
        {
            this.recipeData = recipeData;
        }
        public IActionResult OnGet(int recipeId)
        {
            Recipe = recipeData.GetById(recipeId);
            if (Recipe == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}