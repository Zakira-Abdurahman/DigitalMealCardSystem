
namespace DigitalMealCardSystem.Domain.Entities;
public class Meal
{ 

    public int MealID { get; set; }
    public int StudentID { get; set; }
    public int MealName { get; set; }
    public MealType MealType { get; set; }
    public DateTime MealDate { get; set; }
    
}
