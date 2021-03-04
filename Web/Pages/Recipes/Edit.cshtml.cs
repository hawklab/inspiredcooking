using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InspiredCooking.Core;
using InspiredCooking.Data;
using static InspiredCooking.Core.Recipe;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace InspiredCooking.Pages.Recipes
{
    public class EditModel : PageModel
    {
        private readonly IRecipeData recipeData;
        private readonly IHtmlHelper htmlHelper;
        private readonly IIngredientData ingredientData;

        [BindProperty]
        public Recipe Recipe { get; set; }
        public IEnumerable<SelectListItem> Cuisines { get; set; }
        public EditModel(IRecipeData recipeData,
                         IHtmlHelper htmlHelper, IIngredientData ingredientData)
        {
            this.recipeData = recipeData;
            this.htmlHelper = htmlHelper;
            this.ingredientData = ingredientData;
        }
        public IActionResult OnGet(int? recipeId)
        {
            Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
            if (recipeId.HasValue)
            {
                Recipe = recipeData.GetById(recipeId.Value);
            }
            else
            {
                Recipe = new Recipe();
            }
            
            if (Recipe == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
                return Page();    
            }
            if (Recipe.Id > 0)
            {
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
            }
            else
            {
                recipeData.Add(Recipe);
                TempData["Message"] = "Recipe Added.";
            }

            recipeData.Commit();
            return RedirectToPage("./Detail", new { recipeId = Recipe.Id});
        }
    }
}
