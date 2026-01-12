/*Scenario 3: Undo Feature in Text Editor
Use Case: Every edit is stored and can be undone step-by-step. Why LinkedList? LIFO structure fits Stack backed by LinkedList.
OOP Concepts:
● Encapsulation: Each change is encapsulated as a state.
● Abstraction: Undo / redo methods simplify complexity.
● Inheritance: State can be a base class for text / image editing.*/


using System;
using System.Collections.Generic;

// Command Interface
interface ICommand
{
	void Execute();
	void Undo();
}

// Receiver
class Document
{
	public string Text = "";
}

// Concrete Command
class TypeCommand : ICommand
{
	Document doc;
	string txt;

	public TypeCommand(Document d, string t)
	{
		doc = d;
		txt = t;
	}

	public void Execute()
	{
		doc.Text += txt;
	}

	public void Undo()
	{
		doc.Text = doc.Text.Substring(0, doc.Text.Length - txt.Length);
	}
}

// Invoker (Undo/Redo Manager)
class CommandManager
{
	LinkedList<ICommand> undo = new();
	LinkedList<ICommand> redo = new();

	public void ExecuteCommand(ICommand cmd)
	{
		cmd.Execute();
		undo.AddFirst(cmd);
		redo.Clear();
	}

	public void Undo()
	{
		if (undo.Count == 0) return;

		var cmd = undo.First.Value;
		undo.RemoveFirst();
		cmd.Undo();
		redo.AddFirst(cmd);
	}

	public void Redo()
	{
		if (redo.Count == 0) return;

		var cmd = redo.First.Value;
		redo.RemoveFirst();
		cmd.Execute();
		undo.AddFirst(cmd);
	}
}
