using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using InspiredCooking.Data;
using InspiredCooking.Core;
using InspiredCooking.Web.Helpers;

namespace InspiredCooking.Pages.Recipes
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRecipeData recipeData;
        public string Message { get; set; }
        public IEnumerable<Recipe> Recipes { get; set; }

        public List<int> CurrentMenu { get; set; }
        public IEnumerable<Recipe> ViewedRecipes { get; set; }

        public ListModel(IConfiguration config,
                        IRecipeData recipeData)
        {
            this.recipeData = recipeData;
            this.config = config;

        }
        public void OnGet(string searchTerm)
        {
            Message = config["Message"];
            Recipes = recipeData.GetRecipesByName(searchTerm);

            CurrentMenu = HttpContext.Session.GetObjectFromJson<List<int>>("CurrentMenu");
            if (CurrentMenu == null)
            {
                CurrentMenu = new List<int>();
            }
            CurrentMenu.Count();

            //Listing Last Recipes Seen
            var ViewedRecipesIds = HttpContext.Session.GetObjectFromJson<List<int>>("ViewedRecipesKey");
            if (ViewedRecipesIds == null)
            {
                ViewedRecipesIds = new List<int>();
            }

            ViewedRecipes = recipeData.GetRecipesByIds(ViewedRecipesIds);
        }
    }
}