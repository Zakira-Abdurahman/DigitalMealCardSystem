
using global::DigitalMealCardSystem.Application.Common.Interfaces.IRepository;
using global::DigitalMealCardSystem.Application.Common.Interfaces.IService;
using global::DigitalMealCardSystem.Domain.Entities;


namespace DigitalMealCardSystem.Application.DigitalMealCardSystem.Services;


public class MealService : IMealService
{
    private readonly IMealRepository _repository;

    public MealService(IMealRepository repository)
    {
        _repository = repository;
    }

    public async Task<Meal> CreateMealAsync(Meal meal)
    {
        // implementation
    }

    public async Task<Meal> UpdateMealAsync(Meal meal)
    {
        // implementation
    }

    public async Task DeleteMealAsync(int mealId)
    {
        // implementation
    }
}
