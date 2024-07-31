using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
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
        
    }

}
