/*Scenario 9: Undo / Redo Manager with Interface-Based Command Pattern
Use Case: Implement an undo/redo manager for operations like typing, deleting, or formatting in a document editor.
Why LinkedList? Acts as a stack for undo and redo operations.
OOP Concepts:
● Interface: Each command implements a common Command interface.
● Polymorphism: Same execute() and undo() method works for different operations.
● Encapsulation & Abstraction: User doesn’t see the inner workings of the command queue.*/


using System;
using System.Collections.Generic;

// Base State Class (Inheritance)
abstract class EditState
{
	public abstract string Content { get; }
}

// Text State Implementation
class TextState : EditState
{
	private string text;

	public TextState(string text)
	{
		this.text = text;
	}
	public override string Content => text;
}

// Editor Class (Encapsulation)
class Editor
{
	private LinkedList<EditState> undoStack = new LinkedList<EditState>();
	private LinkedList<EditState> redoStack = new LinkedList<EditState>();

	public void Edit(EditState state)
	{
		undoStack.AddFirst(state);
		redoStack.Clear(); // clear redo history
		Console.WriteLine("Edited: " + state.Content);
	}

	public void Undo()
	{
		if (undoStack.Count == 0)
		{
			Console.WriteLine("Nothing to undo.");
			return;
		}

		EditState state = undoStack.First.Value;
		undoStack.RemoveFirst();
		redoStack.AddFirst(state);

		Console.WriteLine("Undo → Current: " +
			(undoStack.First?.Value.Content ?? "Empty"));
	}

	public void Redo()
	{
		if (redoStack.Count == 0)
		{
			Console.WriteLine("Nothing to redo.");
			return;
		}

		EditState state = redoStack.First.Value;
		redoStack.RemoveFirst();
		undoStack.AddFirst(state);

		Console.WriteLine("Redo → Current: " + state.Content);
	}
}
