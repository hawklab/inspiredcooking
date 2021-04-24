using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspiredCooking.Core;
using Microsoft.EntityFrameworkCore;


namespace InspiredCooking.Data
{
    public class SqlStepData : IStepData
    {
        private readonly InspiredCookingDbContext db;

        public SqlStepData(InspiredCookingDbContext db)
        {
            this.db = db;
        }

        public Step Add(Step newStep)
        {
            db.Add(newStep);
            return newStep;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Step Delete(int id)
        {
            var step = GetById(id);
            if (step != null)
            {
                db.Steps.Remove(step);
            }
            return step;
        }

        public Step GetById(int id)
        {
            return db.Steps.Find(id);
        }

        public IEnumerable<Step> GetStepsByTitle(string title)
        {
            var query = from r in db.Steps
                        where r.Title.StartsWith(title) || string.IsNullOrEmpty(title)
                        orderby r.Title
                        select r;
            return query;
        }

        public Step Update(Step updatedStep)
        {
            var entity = db.Steps.Attach(updatedStep);
            entity.State = EntityState.Modified;
            return updatedStep;
        }
    }
}
