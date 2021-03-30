using System;

namespace InspiredCooking.Core
{
    public partial class FavoriteRecipe
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Recipe Recipe { get; set; }
        public int RecipeId { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}
