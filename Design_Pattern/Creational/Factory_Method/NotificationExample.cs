using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Creational.Factory_Method
{
    //Product(Interface)
    public interface INotifier
    {
        void SendNotification(string message);
    }
    // Concrete Products
    public class EmailNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
            // Actual email sending logic goes here...
        }
    }
    public class SMSNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
            // Actual SMS sending logic goes here...
        }
    }
    public class PushNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending Push Notification: {message}");
            // Actual push notification logic goes here...
        }
    }
    //Creator (Abstract Class)
    public abstract class NotifierFactory
    {
        public abstract INotifier CreateNotifier();
    }
    //Concrete Creators
    public class EmailNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new EmailNotifier();
        }
    }
    public class SMSNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new SMSNotifier();
        }
    }
    public class PushNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new PushNotifier();
        }
    }
    //Client Code
    public class NotificationSystem
    {
        public void NotifyUser(NotifierFactory factory, string message)
        {
            INotifier notifier = factory.CreateNotifier();
            notifier.SendNotification(message);
        }
    }
}

/*
    var notificationSystem = new NotificationSystem();
    // For a user who prefers email notifications:
    notificationSystem.NotifyUser(new EmailNotifierFactory(), "This is an email notification!");
    // For a user who prefers SMS notifications:
    notificationSystem.NotifyUser(new SMSNotifierFactory(), "This is an SMS notification!");
    // For a user who prefers push notifications:
    notificationSystem.NotifyUser(new PushNotifierFactory(), "This is a push notification!");
    Console.ReadKey();
 */