using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InspiredCooking.Core;
using InspiredCooking.Data;
using Microsoft.AspNetCore.Http;
using InspiredCooking.Web.Helpers;

namespace InspiredCooking.Pages.Recipes
{
    public class DetailModel : PageModel
    {
        private readonly IRecipeData recipeData;


        [TempData]
        public string Message { get; set; }

        public Recipe Recipe { get; set; }

        public bool IsSaved { get; set; }

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

            var savedRecipe = HttpContext.Session.GetObjectFromJson<int[]>("CurrentMenu");

            if (savedRecipe != null)
            {
                this.IsSaved = savedRecipe.Contains(recipeId);
            }
            return Page();
        }
    }
}