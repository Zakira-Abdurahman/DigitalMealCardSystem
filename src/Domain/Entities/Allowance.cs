

namespace DigitalMealCardSystem.Domain.Entities;
public class Allowance
{
    public int AllowanceID { get; set; }
    public int StudentID { get; set; }
    public decimal AllowanceAmount { get; set; }
    public DateTime AllowanceDate { get; set; }
}
