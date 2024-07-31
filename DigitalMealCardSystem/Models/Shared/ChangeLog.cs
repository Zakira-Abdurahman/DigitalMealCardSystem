namespace DigitalMealCardSystem.Models.Shared
{
    public class ChangeLog
    {
        public int UserId { get; set; }
        public string Entity { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
