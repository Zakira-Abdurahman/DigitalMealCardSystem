

namespace DigitalMealCardSystem.Domain.Entities;
public class Payment 

{
    public int PaymentID { get; set; }
    public int StudentID { get; set; }
    public decimal PaymentAmount { get; set; }
    public DateTime PaymentDate { get; set; }
}

