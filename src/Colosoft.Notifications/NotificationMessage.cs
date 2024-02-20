namespace Colosoft.Notifications
{
    public class NotificationMessage
    {
        public NotificationSeverity Severity { get; set; } = NotificationSeverity.Info;

        public string Summary { get; set; }

        public string Details { get; set; }

        public double Duration { get; set; }
    }
}