using InspiredCooking.Core;

namespace InspiredCooking.Data
{
    public interface IFavoriteRecipeData
    {
        bool AddToFavorites(Recipe recipe, ApplicationUser user);
    }
}

