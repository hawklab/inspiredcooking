using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspiredCooking.Core;

namespace InspiredCooking.Data
{
    public class SqlFavoriteRecipeData : IFavoriteRecipeData
    {
        private readonly InspiredCookingDbContext db;
        public SqlFavoriteRecipeData (InspiredCookingDbContext db)
        {
            this.db = db;
        }

        public bool AddToFavorites(Recipe recipe, ApplicationUser user)
        {
            throw new NotImplementedException();
        }


    }

    
}
