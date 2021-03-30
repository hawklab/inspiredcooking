using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InspiredCooking.Core;
using InspiredCooking.Data;
using static InspiredCooking.Core.Recipe;
using Microsoft.AspNetCore.Identity;

namespace InspiredCooking.Pages.Recipes
{
    public class CreateModel : PageModel
    {
        private readonly IRecipeData recipeData;
        private readonly IHtmlHelper htmlHelper;
        private readonly IIngredientData ingredientData;

        private readonly UserManager<ApplicationUser> userManager;

        [BindProperty]
        public Recipe Recipe { get; set; }
        public IEnumerable<SelectListItem> Cuisines { get; set; }
        public CreateModel(IRecipeData recipeData, IHtmlHelper htmlHelper, 
                           IIngredientData ingredientData, 
                           UserManager<ApplicationUser> userManager)
        {
            this.recipeData = recipeData;
            this.htmlHelper = htmlHelper;
            this.ingredientData = ingredientData;
            this.userManager = userManager;
        }
        public IActionResult OnGet(int? recipeId)
        {
            Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
            Recipe = new Recipe();
            return Page();
        }
        public IActionResult OnPost()
        {
            var userId = userManager.GetUserId(User);

            if (!ModelState.IsValid)
            {
                Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
                return Page();    
            }

            Recipe.UserId = userId;
            recipeData.Add(Recipe);
            TempData["Message"] = "Recipe Added.";
            recipeData.Commit();
            return RedirectToPage("./Detail", new { recipeId = Recipe.Id});
        }
    }
}
