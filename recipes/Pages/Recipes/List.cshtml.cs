using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using recipes.Data;
using recipes.Core;

namespace recipes.Pages.Recipes
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRecipeData recipeData;
        public string Message { get; set; }
        public IEnumerable<Recipe> Recipes { get; set; }

        public ListModel(IConfiguration config,
                        IRecipeData recipeData)
        {
            this.recipeData = recipeData;
            this.config = config;

        }
        public void OnGet()
        {
            Message = config["Message"];
            Recipes = recipeData.GetAll();
        }
    }
}