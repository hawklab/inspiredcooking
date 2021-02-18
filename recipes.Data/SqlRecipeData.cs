using System.Collections.Generic;
using recipes.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace recipes.Data
{
    public class SqlRecipeData : IRecipeData
    {
        private readonly RecipesDbContext db;

        public SqlRecipeData(RecipesDbContext db)
        {
            this.db = db;
        }
        public Recipe Add(Recipe newRecipe)
        {
            db.Add(newRecipe);
            return newRecipe;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Recipe Delete(int id)
        {
            var recipe = GetById(id);
            if(recipe !=null)
            {
                db.Recipes.Remove(recipe);
            }
            return recipe;
        }

        public Recipe GetById(int id)
        {
            return db.Recipes.Find(id);
        }

        public IEnumerable<Recipe> GetRecipesByName(string name)
        {
            var query = from r in db.Recipes
                        where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Name
                        select r;
            return query;
        }

        public Recipe Update(Recipe updatedRecipe)
        {
            var entity = db.Recipes.Attach(updatedRecipe);
            entity.State = EntityState.Modified;
            return updatedRecipe;
        }

    }
}