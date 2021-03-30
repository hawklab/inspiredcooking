﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace InspiredCooking.Core
{
    public class ApplicationUser : IdentityUser
    {
        public string DisplayName { get; set; }

        public IEnumerable<FavoriteRecipe> FavoriteRecipes { get; set; }
    }
}
