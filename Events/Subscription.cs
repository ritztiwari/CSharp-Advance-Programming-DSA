//Event with Custom Message

//Create an event that passes a message string to the subscriber.

using System;

internal class Subscription
{
    public delegate void Subscriptions();

    public event Subscriptions subs;

    public void Subscribe()
    {
        Console.WriteLine("button pressed");

        subs?.Invoke();
    }
}

class Message
{
    public void Show()
    {
        Console.WriteLine("Screen received the click event for subscription and accepted it.");
    }
}