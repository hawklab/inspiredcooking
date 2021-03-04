using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InspiredCooking.Core;
using InspiredCooking.Data;

namespace InspiredCooking.Pages.Ingredients
{
    public class ListModel : PageModel
    {
        private readonly IIngredientData ingredientData;

        public IEnumerable<Ingredient> Ingredients { get; set; }

        public ListModel(IIngredientData ingredientData)
        {
 
            this.ingredientData = ingredientData;
        }
        public void OnGet(string searchTerm)
        {
            Ingredients = ingredientData.GetIngredientsByName(searchTerm);
        }
    }
}