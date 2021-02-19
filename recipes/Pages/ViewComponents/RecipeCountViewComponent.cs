using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using recipes.Data;

namespace recipes.Pages.ViewComponents
{
    public class RecipeCountViewComponent
        : ViewComponent
    {
        private readonly IRecipeData recipeData;

        public RecipeCountViewComponent(IRecipeData recipeData)
        {
            this.recipeData = recipeData;
        }

        public IViewComponentResult Invoke()
        {
            var count = recipeData.GetCountOfRecipes();
            return View(count);
        }
    }

    

}
