namespace DigitalMealCardSystem.Models.Shared
{
    public class SecurityIncidentLog
    {
        public string IncidentDetails { get; set; }
        public string AffectedResources { get; set; }
        public string ResponseActions { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
