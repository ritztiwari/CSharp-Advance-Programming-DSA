using System;

internal class PublisherSubscriber
{
    public delegate string Message();

    public event Message message;

    public void MessageSent()
    {
        Console.WriteLine("message sent by the publisher");

        message?.Invoke();
    }
}

class Subscriber
{
    public string MessageToSubscriber()
    {
        //Console.WriteLine("message received by the subscriber");
        return "message received by the subscriber";
    }
}