/*Custom Notification System with Interface and LinkedList
Use Case: Deliver notifications of different types (Email, SMS, Push) and store them in a delivery queue.
OOP Concepts:
● Interface: Notification interface represents all types.
● Polymorphism: Each notification type handles delivery differently.
● Encapsulation: NotificationQueue hides internal structure.
● Abstraction: Only add() and sendAll() methods are exposed.*/


using System;
using System.Collections.Generic;

// Notification Interface
interface INotification
{
	void Send();
}

// Email Notification
class EmailNotification : INotification
{
	public void Send()
	{
		Console.WriteLine("Sending Email Notification");
	}
}

// SMS Notification
class SmsNotification : INotification
{
	public void Send()
	{
		Console.WriteLine("Sending SMS Notification");
	}
}

// Push Notification
class PushNotification : INotification
{
	public void Send()
	{
		Console.WriteLine("Sending Push Notification");
	}
}

// Notification Queue (Encapsulation + Abstraction)
class NotificationQueue
{
	private LinkedList<INotification> queue = new();

	public void Add(INotification notification)
	{
		queue.AddLast(notification);
	}

	public void SendAll()
	{
		foreach (var n in queue)
			n.Send();
	}
}
