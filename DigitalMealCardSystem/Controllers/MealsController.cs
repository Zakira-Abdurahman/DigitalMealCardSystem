using DigitalMealCardSystem.Data;
using DigitalMealCardSystem.Models.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class MealsController : ControllerBase
{

    private readonly MealCardContext _context;


    private readonly AuditLog _auditLog;
    private readonly ChangeLog _changeLog;
    private readonly ExceptionLog _exceptionLog;
    private readonly SecurityIncidentLog _incidentLog;
    private readonly UserActivityLog _userActivityLog;
    private readonly AccessControllerLog _accessControllerLog;

    public MealsController(

        MealCardContext context,

        AuditLog auditLog,
            ChangeLog changeLog,
            ExceptionLog exceptionLog,
            SecurityIncidentLog incidentLog,
            UserActivityLog userActivityLog,
            AccessControllerLog accessControllerLog
        )


    {
        _context = context;


        _auditLog = auditLog;
        _changeLog = changeLog;
        _exceptionLog = exceptionLog;
        _incidentLog = incidentLog;
        _userActivityLog = userActivityLog;
        _accessControllerLog = accessControllerLog;

    }


    // GET: api/Meals
    [HttpGet]

    public async Task<ActionResult<IEnumerable<Meal>>> GetMeals()
    {
        // Log user activity
        _userActivityLog.LogActivity(User.Identity.Name, "GetMeals", "Retrieved meal list");

        return await _context.Meals.ToListAsync();
    }
    // GET: api/Meals/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Meal>> GetMeal(int id)
    {
        var meal = await _context.Meals.FindAsync(id);

        if (meal == null)
        {
            // Log security incident

            return NotFound();
        }

        // Log user activity
        _userActivityLog.LogActivity(User.Identity.Name, "GetMeal", $"Retrieved meal with ID: {id}");

        return meal;
    }

    // POST: api/Meals
    [HttpPost]
    public async Task<ActionResult<Meal>> PostMeal(Meal meal)
    {
        if(meal == null)
            return NotFound();
       var isexist= _context.Meals.Where(m=>m.Name== meal.Name).FirstOrDefault();
        if (isexist != null)
            return null;

        _context.Meals.Add(meal);
        await _context.SaveChangesAsync();

        // Log change

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
            // Log security incident
            return NotFound();
        }
        else
        {
            throw;
        }
    }

    // Log change
    return NoContent();
}
// DELETE: api/Meals/5
[HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMeal(int id)
    {
        var meal = await _context.Meals.FindAsync(id);
        if (meal == null)
        {
        // Log security incident

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
