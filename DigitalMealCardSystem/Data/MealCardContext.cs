using DigitalMealCardSystem.Models;
using DigitalMealCardSystem.Models.Shared;
using Microsoft.EntityFrameworkCore;

namespace DigitalMealCardSystem.Data
{
    public class MealCardContext : DbContext
    {



        public MealCardContext(DbContextOptions<MealCardContext> options) : base(options) { }

       public DbSet<Student> Students { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Payment> LogActivity { get; set; }

    }
}
