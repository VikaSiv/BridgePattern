using Bridge_Pattern;

namespace NotificationSystem
{

    public interface INotificationSender
    {
        void SendNotification(string message, string recipient);
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            INotificationSender emailSender = new EmailNotificationSender();
            Notification emailTextNotification = new TextNotification(emailSender);
            emailTextNotification.Notify("Привет! Это текстовое сообщение.", "example@example.com");

            Notification emailHtmlNotification = new HtmlNotification(emailSender);
            emailHtmlNotification.Notify("Привет! <b>Это HTML сообщение.</b>", "example@example.com");

            
            INotificationSender smsSender = new SmsNotificationSender();
            Notification smsTextNotification = new TextNotification(smsSender);
            smsTextNotification.Notify("Привет! Это текстовое SMS.", "+1234567890");

            Notification smsHtmlNotification = new HtmlNotification(smsSender);
            smsHtmlNotification.Notify("Привет! <b>Это HTML SMS.</b>", "+1234567890");

            Console.ReadLine();
        }
    }
}
