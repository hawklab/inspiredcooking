using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InspiredCooking.Core;
using InspiredCooking.Data;
using static InspiredCooking.Core.Recipe;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace InspiredCooking.Pages.Recipes
{
    public class CreateModel : PageModel
    {
        private readonly IRecipeData recipeData;
        private readonly IHtmlHelper htmlHelper;
        private readonly IIngredientData ingredientData;
        private readonly IImageData imageData;

        private readonly UserManager<ApplicationUser> userManager;

        [BindProperty]
        public Recipe Recipe { get; set; }

        [BindProperty]
        public IFormFile NewImage { get; set; }
        public IEnumerable<SelectListItem> Cuisines { get; set; }
        public IEnumerable<SelectListItem> Difficulty { get; set; }
        public CreateModel(IRecipeData recipeData, IHtmlHelper htmlHelper, 
                           IIngredientData ingredientData, 
                           UserManager<ApplicationUser> userManager,
                           IImageData imageData)
        {
            this.recipeData = recipeData;
            this.htmlHelper = htmlHelper;
            this.ingredientData = ingredientData;
            this.imageData = imageData;
            this.userManager = userManager;
        }
        public IActionResult OnGet(int? recipeId)
        {
            Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
            Difficulty = htmlHelper.GetEnumSelectList<DifficultyType>();
            Recipe = new Recipe();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var userId = userManager.GetUserId(User);

            if (!ModelState.IsValid)
            {
                Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
                Difficulty = htmlHelper.GetEnumSelectList<DifficultyType>();
                return Page();    
            }

            if (NewImage != null)
            {
                var image = await imageData.UploadImageAsync(NewImage);
                Recipe.ImageUrl = image;
            }

            Recipe.UserId = userId;
            recipeData.Add(Recipe);
            TempData["Message"] = "Recipe Added.";
            recipeData.Commit();
            return RedirectToPage("./Detail", new { recipeId = Recipe.Id});
        }
    }
}
