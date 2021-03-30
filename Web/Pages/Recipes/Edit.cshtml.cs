using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InspiredCooking.Core;
using InspiredCooking.Data;
using static InspiredCooking.Core.Recipe;
using Microsoft.AspNetCore.Identity;

namespace InspiredCooking.Pages.Recipes
{
    public class EditModel : PageModel
    {
        private readonly IRecipeData recipeData;
        private readonly IHtmlHelper htmlHelper;
        private readonly IIngredientData ingredientData;

        private readonly UserManager<ApplicationUser> userManager;

        [BindProperty]
        public Recipe Recipe { get; set; }
        public IEnumerable<SelectListItem> Cuisines { get; set; }
        public EditModel(IRecipeData recipeData,
                         IHtmlHelper htmlHelper, IIngredientData ingredientData, UserManager<ApplicationUser> userManager)
        {
            this.recipeData = recipeData;
            this.htmlHelper = htmlHelper;
            this.ingredientData = ingredientData;
            this.userManager = userManager;
        }
        public IActionResult OnGet(int? recipeId)
        {
            // authorizing the user to edit their own recipes
            //var currentUser = userManager.GetUserId(User); 
            //var author = Recipe.UserId; 
            
            //if (currentUser == author)
            //{

            //}

           
            Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
            Recipe = recipeData.GetById(recipeId.Value);
            if (Recipe == null)
            {
                return RedirectToPage("./NotFound");
            }
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

            // Update existing Ingredients
            var savedIngredients = new List<int>();
            foreach (var ingredient in Recipe.Ingredients)
            {
                if (ingredient.Id > 0)
                {
                    savedIngredients.Add(ingredient.Id);
                    ingredientData.Update(ingredient);
                }
            }

            // Delete removed ingredients
            var originalRecipe = recipeData.GetById(Recipe.Id);
            var deletedIngredients = originalRecipe.Ingredients.Where(i => !savedIngredients.Contains(i.Id));
            foreach (var deletedIngredient in deletedIngredients)
            {
                ingredientData.Delete(deletedIngredient.Id);
            }    
        
            // Update Recipe
            recipeData.Update(Recipe);
            TempData["Message"] = "Recipe Updated.";
            recipeData.Commit();
            return RedirectToPage("./Detail", new { recipeId = Recipe.Id});
        }
    }
}
