using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace InspiredCooking.Core
{
    public partial class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Amount { get; set; }

        public UnitType Unit { get; set; }

        // Reference property back to Recipe
        [JsonIgnore]
        public Recipe Recipe { get; set; }

        //Explicit integer property containing the foreign key value
        public int RecipeId { get; set; }
    }
}
