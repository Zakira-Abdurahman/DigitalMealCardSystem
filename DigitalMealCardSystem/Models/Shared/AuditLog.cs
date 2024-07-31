using DigitalMealCardSystem;

namespace DigitalMealCardSystem.Models.Shared
{
    public class AuditLog
    {
        public RecordStatus RecordStatus { get; set; }
        public string Created_by { get; set; }
        public string Updatedby { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
