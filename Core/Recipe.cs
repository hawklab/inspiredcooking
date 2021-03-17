using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace InspiredCooking.Core
{
    public partial class Recipe
    {

        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        public string Photo { get; set; }

        [Required]
        public string PrepTime { get; set; }

        [Required]
        public string CookTime { get; set; }

        [Required]
        public int Servings { get; set; }

        [Required]
        public int Difficulty { get; set; }

        [Required]
        public CuisineType Cuisine { get; set; }

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public IdentityUser User { get; set; }

        public string UserId { get; set; }
    }
}