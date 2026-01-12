/*Scenario 13: Customer Support Chat Queue System
Use Case: Customers are put in a queue to chat with the next available agent.
Why LinkedList? FIFO nature helps maintain order of service.
OOP Concepts:
● Interface: UserRequest for any type of request(chat, call, email).
● Polymorphism: Different request types handled uniformly.
● Encapsulation: Request queue is managed privately.
● Abstraction: Simple API to add / request service.*/


using System;
using System.Collections.Generic;

// Interface for all request types
interface IUserRequest
{
	void Handle();
}

// Chat Request
class ChatRequest : IUserRequest
{
	public void Handle()
	{
		Console.WriteLine("Handling Chat Request");
	}
}

// Call Request
class CallRequest : IUserRequest
{
	public void Handle()
	{
		Console.WriteLine("Handling Call Request");
	}
}

// Email Request
class EmailRequest : IUserRequest
{
	public void Handle()
	{
		Console.WriteLine("Handling Email Request");
	}
}

// Support Queue (Encapsulation)
class SupportQueue
{
	private LinkedList<IUserRequest> requests = new();

	public void AddRequest(IUserRequest request)
	{
		requests.AddLast(request); // FIFO
	}

	public void ServeNext()
	{
		if (requests.Count == 0)
		{
			Console.WriteLine("No pending requests");
			return;
		}

		IUserRequest request = requests.First.Value;
		requests.RemoveFirst();
		request.Handle();
	}
}
