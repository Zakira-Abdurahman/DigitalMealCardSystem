using DigitalMealCardSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class Student
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    [Required]
    public string UniversityId { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    public string Phone { get; set; }
    public string CafeteriaStatus { get; set; }
    public decimal MonthlyAllowance { get; set; } = 0;
    public string GraduationStatus { get; set; }
    public bool TemporaryResultIssued { get; set; }
    public bool OriginalDocumentIssued { get; set; }
    //public ICollection<Transaction> Transactions { get; set; }
    //public ICollection<Payment> Payments { get; set; }
}
