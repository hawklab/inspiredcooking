using System.Collections.Generic;
using InspiredCooking.Core;
using InspiredCooking.Data;
using Microsoft.AspNetCore.Http;
using InspiredCooking.Web.Helpers;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InspiredCooking.Web.Pages.Recipes
{
    public class MenuModel : PageModel
    {
        private readonly IRecipeData recipeData;
        public IEnumerable<Recipe> Recipes { get; set; }
        public List<int> CurrentMenu { get; set; }

        public MenuModel(IRecipeData recipeData)
        {
            this.recipeData = recipeData;
        }
        public void OnGet()
        {
            CurrentMenu = HttpContext.Session.GetObjectFromJson<List<int>>("CurrentMenu");
            if (CurrentMenu == null)
            {
                // CurrentMenu = new List<int>();
                CurrentMenu = new List<int>() { 3, 4 };
            }

            Recipes = recipeData.GetRecipesByIds(CurrentMenu);
        }
    }
}
