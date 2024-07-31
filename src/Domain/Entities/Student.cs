

namespace DigitalMealCardSystem.Domain.Entities
{
    public class Student 
    {
        public int StudentID { get; set; }
        public required string Name { get; set; }
        public required string UniversityId { get; set; }

        public required string Email { get; set; }
        public required string Phone { get; set; }
        public bool IsCafeStudent { get; set; }
        public GraduationStatus GraduationStatus { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DocumentStatus DocumentStatus { get; set; }
    }
}
