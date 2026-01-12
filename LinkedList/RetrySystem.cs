/* Scenario 14: Notification Retry Mechanism
Use Case: Failed notifications(e.g., SMS or email) are retried after failure in FIFO order.
Why LinkedList? Keeps retry order simple and efficient.
OOP Concepts:
● Interface: RetryableTask for various retry operations.
● Polymorphism: Allows different task types to be retried uniformly.
● Abstraction: Retry logic is hidden.
● Encapsulation: Linked list maintains retry queue.*/


using System;
using System.Collections.Generic;

// Interface for retryable tasks
interface IRetryableTask
{
	void Execute();
}

// SMS Task
class SmsTask : IRetryableTask
{
	public void Execute()
	{
		Console.WriteLine("Executing SMS Task");
	}
}

// Email Task
class EmailTask : IRetryableTask
{
	public void Execute()
	{
		Console.WriteLine("Executing Email Task");
	}
}

// Retry Queue (Encapsulation)
class RetryQueue
{
	private LinkedList<IRetryableTask> queue = new();

	public void AddTask(IRetryableTask task)
	{
		queue.AddLast(task); // FIFO order
	}

	public void RetryAll()
	{
		while (queue.Count > 0)
		{
			var task = queue.First.Value;
			queue.RemoveFirst();
			task.Execute();
		}
	}
}
