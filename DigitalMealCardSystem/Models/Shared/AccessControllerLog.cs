namespace DigitalMealCardSystem.Models.Shared
{
    public class AccessControllerLog
    {
        public int UserId { get; set; }
        public string Resource { get; set; }
        public DateTime Timestamp { get; set; }
        public bool Allowed { get; set; }
    }
}
