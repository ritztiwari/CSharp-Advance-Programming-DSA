//Scenario 1: Browser History Navigation
//Use Case: Maintain a user’s browsing history with the ability to move back and forth.
//Why LinkedList? Doubly linked list makes it easy to navigate both backward and forward.
//OOP Concepts:
//● Encapsulation: Browser history data is wrapped inside a class.
//● Abstraction: Navigation methods hide internal implementation.
//● Inheritance & Polymorphism: Reusable navigation for other apps like music players.

using System;

//base node class 
class Node
{
    public string data;
    public Node prev;
    public Node next;

    //constructor for node class 
    public Node(string data)
    {
        this.data = data;
        this.prev = null;
        this.next = null;
    }
}

abstract class NavigationSystem
{
    //current url 
    protected Node current;

    //abstract method for Visit.
    public abstract void Visit(string url);

    //method to backward in the history.
    public virtual void Backward()
    {
        if (current != null && current.prev != null)
        {
            current = current.prev;
            Console.WriteLine($"navigated to url: {current.data}");
        }
        else
        {
            Console.WriteLine("no previous available");
        }
    }

    //method to forward in the history.
    public virtual void Forward()
    {
        if (current != null && current.next != null)
        {
            current = current.next;
            Console.WriteLine($"navigated to url: {current.data}");
        }
        else
        {
            Console.WriteLine("no next available");
        }
    }

}
   
class BrowserNavigation : NavigationSystem
{
    //Visit method overrided in the browser navigation class.
    public override void Visit(string url)
    {
        Node newNode = new Node(url);
        if (current != null)
        {
            current.next = newNode;
            newNode.prev = current;
        }
        current = newNode;
        Console.WriteLine("Visited to: " + current.data);
    }
}