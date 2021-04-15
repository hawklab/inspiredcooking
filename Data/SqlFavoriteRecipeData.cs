using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspiredCooking.Core;

namespace InspiredCooking.Data
{
    public class SqlFavoriteRecipeData : IFavoriteRecipeData
    {
        private readonly InspiredCookingDbContext db;
        public SqlFavoriteRecipeData (InspiredCookingDbContext db)
        {
            this.db = db;
        }

        public void AddToFavorites(Recipe recipe, ApplicationUser user)
        {
            if(IsFavorited(recipe,user))
            {
                return;
            }

            var favorited = new FavoriteRecipe();
            favorited.RecipeId = recipe.Id;
            favorited.UserId = user.Id;
            //favorited.CreatedAt = DateTime.Now;
            db.Add(favorited);
            db.SaveChanges();
        }

        public bool IsFavorited(Recipe recipe, ApplicationUser user)
        {
            if(user == null)
            {
                return false;
            }

            var favoriteRecord = db.FavoriteRecipes.Where(f => f.RecipeId == recipe.Id && f.UserId == user.Id)
                             .FirstOrDefault();
            if(favoriteRecord == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool RemoveFromFavorites(Recipe recipe, ApplicationUser user)
        {
            var favorite = db.FavoriteRecipes.Where(f => f.RecipeId == recipe.Id && f.UserId == user.Id)
                              .First();
            db.Remove(favorite);
            db.SaveChanges();

            return true;
        }

    }

    
}
