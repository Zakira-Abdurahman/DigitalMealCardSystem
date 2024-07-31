using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    
    public class Meal
    {
        public int Id { get; private set; }
        public MealType MealType { get; private set; }
        public DateTime MealDate { get; private set; }

        public Meal(int id, MealType mealType, DateTime mealDate)
        {
            Id = id;
            MealType = mealType;
            MealDate = mealDate;
        }
    }
}
