using InspiredCooking.Core;

namespace InspiredCooking.Data
{
    public interface IFavoriteRecipeData
    {
        void AddToFavorites(Recipe recipe, ApplicationUser user);
        bool RemoveFromFavorites(Recipe recipe, ApplicationUser user);

        bool IsFavorited (Recipe recipe, ApplicationUser user);
    }
}

