
namespace DigitalMealCardSystem.Domain.Entities;
public class Transaction 

{
    public int TransactionID { get; set; }
    public int MealID { get; set; }
    public DateTime TransactionDate { get; set; }
}
