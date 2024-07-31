using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services.MealManagement
{
    public interface IMealService
    {
        Meal GetMeal(int id);
        IEnumerable<Meal> GetMeals();
        void CreateMeal(Meal meal);
        void UpdateMeal(Meal meal);
        void DeleteMeal(int id);
    }
}
