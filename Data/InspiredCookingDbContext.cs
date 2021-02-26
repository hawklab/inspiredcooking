using Microsoft.EntityFrameworkCore;
using InspiredCooking.Core;

namespace InspiredCooking.Data
{
    public class InspiredCookingDbContext : DbContext
    {
        public InspiredCookingDbContext(DbContextOptions<InspiredCookingDbContext> options)
            : base(options)
        {

        }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
