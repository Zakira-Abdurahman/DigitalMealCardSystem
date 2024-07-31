using DigitalMealCardSystem.Data;
using DigitalMealCardSystem.Models.Shared;
using Microsoft.EntityFrameworkCore;

namespace DigitalMealCardSystem.Models.Shared
{
    public class UserActivityLog
    {
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Action { get; set; }
        private readonly MealCardContext _context;
        public UserActivityLog(MealCardContext context)
        {
            _context = context;
        }
        public List<Meal> LogActivity(string name, string type, string topic)
        {
            return _context.Meals.Where(n=>n.Name==name).ToList();
        }
    }
}


