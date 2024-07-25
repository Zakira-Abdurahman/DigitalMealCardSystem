public class Meal
{
    public int MealID { get; set; }
    public string MealType { get; set; }
    public DateTime MealDate { get; set; }
    public ICollection<Transaction> Transactions { get; set; }
}
