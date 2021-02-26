using System.Collections.Generic;
using InspiredCooking.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InspiredCooking.Data
{
    public class SqlIngredientData : IIngredientData
    {
        private readonly InspiredCookingDbContext db;

        public SqlIngredientData(InspiredCookingDbContext db)
        {
            this.db = db;
        }
        public Ingredient Add(Ingredient newIngredient)
        {
            db.Add(newIngredient);
            return newIngredient;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Ingredient Delete(int id)
        {
            var ingredient = GetById(id);
            if(ingredient !=null)
            {
                db.Ingredients.Remove(ingredient);
            }
            return ingredient;
        }
  
        public Ingredient GetById(int id)
        {
            return db.Ingredients.Find(id);
        }

        public int GetCountOfIngredients()
        {
            return db.Ingredients.Count();
        }

        public IEnumerable<Ingredient> GetIngredientsByName(string name)
        {
            var query = from r in db.Ingredients
                        where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Name
                        select r;
            return query;
        }

        public Ingredient Update(Ingredient updatedIngredient)
        {
            var entity = db.Ingredients.Attach(updatedIngredient);
            entity.State = EntityState.Modified;
            return updatedIngredient;
        }

    }
}