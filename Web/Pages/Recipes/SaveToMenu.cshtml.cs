using System.Collections.Generic;
using InspiredCooking.Web.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InspiredCooking.Web.Pages.Recipes
{
    public class SaveToMenuModel : PageModel
    {

        public ActionResult OnGet(int recipeId)
        {
            var currentMenu = HttpContext.Session.GetObjectFromJson<List<int>>("CurrentMenu");

            if (currentMenu == null)
            {
                currentMenu = new List<int>();
            }
            currentMenu.Add(recipeId);
            HttpContext.Session.SetObjectAsJson("CurrentMenu", currentMenu);

            
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
 }
