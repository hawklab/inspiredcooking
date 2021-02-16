using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using recipes.Core;
using recipes.Data;
using static recipes.Core.Recipe;

namespace recipes.Pages.Recipes
{
    public class EditModel : PageModel
    {
        private readonly IRecipeData recipeData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Recipe Recipe { get; set; }
        public IEnumerable<SelectListItem> Cuisines { get; set; }
        public EditModel(IRecipeData recipeData,
                         IHtmlHelper htmlHelper)
        {
            this.recipeData = recipeData;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int recipeId)
        {

            Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
            Recipe = recipeData.GetById(recipeId);
            if (Recipe == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                recipeData.Update(Recipe);
                recipeData.Commit();
                return RedirectToPage("./Detail", new { recipeId = Recipe.Id});
            }
            Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
            return Page();
        }
    }
}