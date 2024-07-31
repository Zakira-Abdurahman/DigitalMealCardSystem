using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services.MealManagement
{
    public class MealService : IMealService
    {
        private readonly IMealRepository _mealRepository;

        public MealService(IMealRepository mealRepository)
        {
            _mealRepository = mealRepository;
        }

        public Meal GetMeal(int id)
        {
            return _mealRepository.Get(id);
        }

        public IEnumerable<Meal> GetMeals()
        {
            return _mealRepository.GetAll();
        }

        public void CreateMeal(Meal meal)
        {
            _mealRepository.Add(meal);
        }

        public void UpdateMeal(Meal meal)
        {
            _mealRepository.Update(meal);
        }

        public void DeleteMeal(int id)
        {
            _mealRepository.Delete(id);
        }
    }
}
