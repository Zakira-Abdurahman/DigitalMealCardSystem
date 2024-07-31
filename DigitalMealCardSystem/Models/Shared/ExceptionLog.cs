namespace DigitalMealCardSystem.Models.Shared
{
    public class ExceptionLog
    {
        public string ExceptionMessage { get; set; }
        public string StackTrace { get; set; }
        public int ErrorCode { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
