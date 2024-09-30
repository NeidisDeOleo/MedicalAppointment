
using System;

namespace MedicalAppoiment.Domain.Entities.Configuration
{
    public sealed class Notification
    {
        public int NotificationId { get; set; }
        public User User { get; set; }
        public string Message { get; set; }
        public DateTime SentAt { get; set; }
    }
}
