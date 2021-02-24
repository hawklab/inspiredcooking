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
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
