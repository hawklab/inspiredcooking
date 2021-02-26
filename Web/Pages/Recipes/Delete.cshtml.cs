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
    public class DeleteModel : PageModel
    {
        private readonly IRecipeData recipeData;

        public Recipe Recipe { get; set; }

        public DeleteModel(IRecipeData recipeData)
        {
            this.recipeData = recipeData;
        }
        public IActionResult OnGet(int recipeId)
        {
            Recipe = recipeData.GetById(recipeId);
            if(Recipe == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost(int recipeId)
        {
            var recipe = recipeData.Delete(recipeId);
            recipeData.Commit();

            if(recipe == null)
            {
                return RedirectToPage("./NotFound");
            }

            TempData["Message"] = $"The recipe {recipe.Name} has been deleted.";
            return RedirectToPage("./List");


        }
    }
}
