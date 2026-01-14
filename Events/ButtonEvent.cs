//Simple Event Example

//Create a Button class that raises a Click event.

//Handle the event in another class.

using System;

internal class ButtonEvent
{
    public delegate void Click();

    public event Click click;

    public void Press()
    {
        Console.WriteLine("button was pressed.");

        click?.Invoke();
    }
}

class Screen 
{
    public void ShowMessage()
    {
        Console.WriteLine("screen received the click event.");
    }
}
