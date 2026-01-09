// 4.Undo Functionality in Drawing App
//Use Case: Maintain stack of actions (line drawn, shape added) and support undo.
//OOP Concepts:
//● Interface: DrawingAction
//● Polymorphism: Multiple actions (line, circle, erase) handled uniformly.
//● Encapsulation: Undo stack wrapped inside the app logic
 

using System;

interface IDrawingAction
{
    void Undo();
}

// subclasses implementing IDrawingAction interface 
class DrawLine : IDrawingAction
{
    public void Undo()
    {
        Console.WriteLine("Undo Line Drawing");
    }
}

class DrawCircle : IDrawingAction
{
    public void Undo()
    {
        Console.WriteLine("Undo Circle Drawing");
    }
}

class Erase : IDrawingAction
{
    public void Undo()
    {
        Console.WriteLine("Undo Erase Action");
    }
}

internal class DrawingApp
{
    // stack of actions
    Stack<IDrawingAction> st = new Stack<IDrawingAction>();

    //performing drawing aciton by using interface
    public void DoTheDrawing(IDrawingAction s)
    {
        st.Push(s);
        Console.WriteLine("drawing done");
    }

    public void Undo()
    {
        if (st.Count > 0)
        {
            IDrawingAction s = st.Pop();
            s.Undo();
        }
        else
            Console.WriteLine("Nothing to undo");
    }
}