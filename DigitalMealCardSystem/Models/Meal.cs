using DigitalMealCardSystem;
using System.ComponentModel;

public class Meal
{
    public int MealID { get; set; }
    public MealType MealType { get; set; }
    public DateTime MealDate { get; set; }
    
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; }= string.Empty;
    public double? Price { get; set; }
}