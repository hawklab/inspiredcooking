using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InspiredCooking.Core
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Reference property back to Recipe
        public Recipe Recipe { get; set; }

        //Explicit integer property containing the foreign key value
        public int RecipeId { get; set; }
    }
}
