//Multicast Delegate

//Create a delegate that returns void.

//Attach multiple methods and observe the execution order.


using System;

public delegate void Greetings();

internal class MulticastDelegate
{
    public static void Morning()
    {
        Console.WriteLine("good morning everyone");
    }

    public static void Afternoon()
    {
        Console.WriteLine("good afternoon");
    }

    public static void Night()
    {
        Console.WriteLine("good night");
    }
}