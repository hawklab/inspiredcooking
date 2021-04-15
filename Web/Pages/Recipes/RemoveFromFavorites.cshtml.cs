using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InspiredCooking.Core;
using InspiredCooking.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InspiredCooking.Web.Pages.Recipes
{
    public class RemoveFromFavoritesModel : PageModel
    {
        private readonly IRecipeData recipeData;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IFavoriteRecipeData favoriteRecipeData;

        public RemoveFromFavoritesModel(IRecipeData recipeData,
                                   UserManager<ApplicationUser> userManager,
                                   IFavoriteRecipeData favoriteRecipeData)
        {
            this.recipeData = recipeData;
            this.userManager = userManager;
            this.favoriteRecipeData = favoriteRecipeData;
        }

        public async Task<ActionResult> OnPostAsync(int recipeId)
        {
            var recipe = recipeData.GetById(recipeId);
            var user = await userManager.GetUserAsync(User);

            favoriteRecipeData.RemoveFromFavorites(recipe, user);

            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
