public class Transaction
{
    public int TransactionID { get; set; }
    public int StudentID { get; set; }
    public int MealID { get; set; }
    public DateTime TransactionTime { get; set; }
    public Student Student { get; set; }
    public Meal Meal { get; set; }
}
