//2.Web Browser Tab Navigation (Back/Forward Tabs)
//Use Case: Users can navigate back and forward between opened tabs.
//OOP Concepts:
//? Interface: NavigationManager
//? Encapsulation: Two stacks handle navigation state.
//? Polymorphism: Could extend for mobile vs desktop browser.

using System;

interface INavigationManager
{
    //navigation manager methods that will be used in class.
    void GoForward();
    void GoBackward();
    void CurrentTab();
    void OpenTab(string url);
}

class NavigationManager : INavigationManager
{
    // stack fields to go forward and backward on the 
    Stack<string> forward = new Stack<string>();
    Stack<string> backward = new Stack<string>();
    string current = null;

    //go forward in the stack to go to the next website.
    public void GoForward()
    {
        if(forward.Count == 0)
        {
            Console.WriteLine("can't go forward no websites available");
        }

        backward.Push(current);
        current = forward.Pop();
        Console.WriteLine($"forward website is: {current}");
    }

    //go backward in the stack to go to last website.
    public void GoBackward()
    {
        if(backward.Count == 0)
        {
            Console.WriteLine("can't go backward no websites available");
        }

        forward.Push(current);
        current = backward.Pop();
        Console.WriteLine($"backward website is: {current}");
    }

    //printing user's current tab website right now.
    public void CurrentTab()
    {
        Console.WriteLine($"current website is: {current}");
    }

    //open the new website.
    public void OpenTab(string url)
    {
        if (current != null)
        {
            backward.Push(current);
        }
        current = url;
        forward.Clear();
        Console.WriteLine($"Current tab is: {current}");
    }
}