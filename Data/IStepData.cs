
using System.Collections.Generic;
using InspiredCooking.Core;

namespace InspiredCooking.Data
{
    public interface IStepData
    {
        IEnumerable<Step>GetStepsByTitle(string title);
        Step GetById(int id);
        Step Update(Step updatedIngredient);
        Step Add(Step newIngredient);
        Step Delete(int id);
        int Commit();
    }
}
