/*Scenario 4: Customer Service Call Center Queue
Use Case: Handle customer support tickets in order of arrival.
Why LinkedList? FIFO nature can be modeled via a queue using LinkedList.
OOP Concepts:
● Abstraction: Add / remove operations for ticket queue.
● Encapsulation: Each ticket is hidden behind methods.
● Polymorphism: Different ticket types (chat, call, email) handled similarly.*/


using System;
using System.Collections.Generic;

// Base Ticket Class (Polymorphism)
public abstract class Ticket
{
	public string Issue { get; }

	protected Ticket(string issue)
	{
		Issue = issue;
	}
	public abstract string GetTicketType();
}

// Call Ticket
public class CallTicket : Ticket
{
	public CallTicket(string issue) : base(issue) { }

	public override string GetTicketType() => "Call";
}

// Chat Ticket
public class ChatTicket : Ticket
{
	public ChatTicket(string issue) : base(issue) { }

	public override string GetTicketType() => "Chat";
}

// Email Ticket
public class EmailTicket : Ticket
{
	public EmailTicket(string issue) : base(issue) { }

	public override string GetTicketType() => "Email";
}

// Queue Manager (Encapsulation + Abstraction)
public class TicketQueue
{
	private LinkedList<Ticket> tickets = new LinkedList<Ticket>();

	public void AddTicket(Ticket ticket)
	{
		tickets.AddLast(ticket);
		Console.WriteLine($"Ticket Added [{ticket.GetTicketType()}]: {ticket.Issue}"); 
	}

	public void ProcessNext()
	{
		if (tickets.Count == 0)
		{
			Console.WriteLine("No pending tickets.");
			return;
		}

		Ticket next = tickets.First.Value;
		tickets.RemoveFirst();

		Console.WriteLine($"Processing [{next.GetTicketType()}]: {next.Issue}");
	}
}
