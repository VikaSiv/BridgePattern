using NotificationSystem;

namespace Bridge_Pattern
{
    public class TextNotification : Notification
    {
        public TextNotification(INotificationSender notificationSender)
            : base(notificationSender) { }

        public override void Notify(string message, string recipient)
        {
            _notificationSender.SendNotification(message, recipient);
        }
    }

    public class HtmlNotification : Notification
    {
        public HtmlNotification(INotificationSender notificationSender)
            : base(notificationSender) { }

        public override void Notify(string message, string recipient)
        {
            string htmlMessage = $"<html><body>{message}</body></html>";
            _notificationSender.SendNotification(htmlMessage, recipient);
        }
    }

}
