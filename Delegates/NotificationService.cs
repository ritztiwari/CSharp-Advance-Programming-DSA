//Delegate Chaining & Removal

//Add multiple methods to a delegate and remove one method at runtime.

using System;

public delegate void Notify();

public class NotificationService 
{
    public static void SendEmail()
    {
        Console.WriteLine("Email notification sent");
    }

    public static void SendSMS()
    {
        Console.WriteLine("SMS notification sent");
    }

    public static void SendPush()
    {
        Console.WriteLine("Push notification sent");
    }
}
