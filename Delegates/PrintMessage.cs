//Delegate with void Return Type

//Define a delegate that prints a message.

//Pass different methods to display.

//Welcome message
//Error message
//Success message

using System;

public delegate void Message(string message);

internal class PrintMessage
{
    public static void WelcomeMessage(string message)
    {
        Console.WriteLine($"welcomes {message}");
    }

    public static void ErrorMessage(string message)
    {
        Console.WriteLine($"errror occured {message}");
    }

    public static void SuccessMessage(string message)
    {
        Console.WriteLine($"success {message}");
    }
}