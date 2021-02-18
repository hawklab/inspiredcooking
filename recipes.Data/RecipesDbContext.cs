using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using recipes.Core;

namespace recipes.Data
{
    public class RecipesDbContext : DbContext
    {
        public RecipesDbContext(DbContextOptions<RecipesDbContext> options)
            : base(options)
        {

        }
        public DbSet<Recipe> Recipes { get; set; }
    }
}
