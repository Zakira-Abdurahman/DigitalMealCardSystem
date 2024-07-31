using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalMealCardSystem.Domain.Entities;

namespace DigitalMealCardSystem.Application.Common.Interfaces.IService;
public interface IMealService
{
    Task<Meal> CreateMealAsync(Meal meal);
    Task<Meal> UpdateMealAsync(Meal meal);
    Task DeleteMealAsync(int mealId);
}
