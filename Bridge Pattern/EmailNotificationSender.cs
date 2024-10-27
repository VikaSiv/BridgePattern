using NotificationSystem;

namespace Bridge_Pattern
{
    public class EmailNotificationSender : INotificationSender
    {
        public void SendNotification(string message, string recipient)
        {
            
            Console.WriteLine($"Email отправлен на {recipient}: {message}");
        }
    }

    public class SmsNotificationSender : INotificationSender
    {
        public void SendNotification(string message, string recipient)
        {
            
            Console.WriteLine($"SMS отправлено на {recipient}: {message}");
        }
    }
}
