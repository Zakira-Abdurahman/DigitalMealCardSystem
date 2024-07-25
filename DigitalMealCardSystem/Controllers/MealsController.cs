using DigitalMealCardSystem.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class MealsController : ControllerBase
{
    private readonly MealCardContext _context;

    public MealsController(MealCardContext context)
    {
        _context = context;
    }

    // GET: api/Meals
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Meal>>> GetMeals()
    {
        return await _context.Meals.ToListAsync();
    }

    // GET: api/Meals/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Meal>> GetMeal(int id)
    {
        var meal = await _context.Meals.FindAsync(id);

        if (meal == null)
        {
            return NotFound();
        }

        return meal;
    }

    // POST: api/Meals
    [HttpPost]
    public async Task<ActionResult<Meal>> PostMeal(Meal meal)
    {
        _context.Meals.Add(meal);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetMeal), new { id = meal.MealID }, meal);
    }

    // PUT: api/Meals/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutMeal(int id, Meal meal)
    {
        if (id != meal.MealID)
        {
            return BadRequest();
        }

        _context.Entry(meal).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!MealExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // DELETE: api/Meals/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMeal(int id)
    {
        var meal = await _context.Meals.FindAsync(id);
        if (meal == null)
        {
            return NotFound();
        }

        _context.Meals.Remove(meal);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool MealExists(int id)
    {
        return _context.Meals.Any(e => e.MealID == id);
    }
}
