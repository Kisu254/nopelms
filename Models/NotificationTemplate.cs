using System;

namespace Lms.Models
{
    public class NotificationTemplate
    {
        public int Id { get; set; }
        public string EventType { get; set; }
        public string DeliveryChannel { get; set; }
        public string Subject { get; set; }
        public string BodyText { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
