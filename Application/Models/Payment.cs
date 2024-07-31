using System.Transactions;

namespace DigitalMealCardSystem.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        // public int StudentID { get; set; }
        public int TransactionID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentStatus { get; set; }
        //public Student Student { get; set; }
        public Transaction Transaction { get; set; }
    }
}
