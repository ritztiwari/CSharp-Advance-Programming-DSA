/*Scenario 7: Social Media Notification Feed
Use Case: Store and display recent notifications for a user in reverse chronological order (most recent first).
Why LinkedList? Fast insert at the beginning and sequential traversal.OOP Concepts:
● Encapsulation: User feed is managed privately.
● Abstraction: API - style access to addNotification() and displayFeed().
● Inheritance/Polymorphism: Different types of notifications (LikeNotification,CommentNotification) can be handled generically.*/


using System;
using System.Collections.Generic;

// Base Notification Class (Polymorphism)
public abstract class Notification
{
	public string Message { get; }

	protected Notification(string message)
	{
		Message = message;
	}

	public abstract string GetTypeName();
}

// Like Notification
public class LikeNotification : Notification
{
	public LikeNotification(string message) : base(message) { }

	public override string GetTypeName() => "Like";
}

// Comment Notification
public class CommentNotification : Notification
{
	public CommentNotification(string message) : base(message) { }

	public override string GetTypeName() => "Comment";
}

// Feed Manager (Encapsulation + Abstraction)
public class NotificationFeed
{
	private LinkedList<Notification> notifications =
		new LinkedList<Notification>();

	public void AddNotification(Notification notification)
	{
		notifications.AddFirst(notification);
		Console.WriteLine($"New {notification.GetTypeName()} Notification Added");
	}

	public void DisplayFeed()
	{
		Console.WriteLine("\n--- Notification Feed ---");
		foreach (var notification in notifications)
		{
			Console.WriteLine(
				$"[{notification.GetTypeName()}] {notification.Message}"
			);
		}
	}
}
