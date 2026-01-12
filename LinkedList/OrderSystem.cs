/*Scenario 11: Order Processing System with Interface for Order Types
Use Case: Process different types of orders: online, offline, subscription.
Why LinkedList? Orders arrive sequentially and are processed in FIFO order.
OOP Concepts:
● Interface: Order interface abstracts order types.
● Polymorphism: process() works differently per order type.
● Encapsulation: The order queue is wrapped and secured.*/


using System;
using System.Collections.Generic;

// Order Interface
interface IOrder
{
	void Process();
}

// Online Order
class OnlineOrder : IOrder
{
	public void Process()
	{
		Console.WriteLine("Processing Online Order");
	}
}

// Offline Order
class OfflineOrder : IOrder
{
	public void Process()
	{
		Console.WriteLine("Processing Offline Order");
	}
}

// Subscription Order
class SubscriptionOrder : IOrder
{
	public void Process()
	{
		Console.WriteLine("Processing Subscription Order");
	}
}

// Order Queue (Encapsulation)
class OrderQueue
{
	private LinkedList<IOrder> orders = new();

	public void AddOrder(IOrder order)
	{
		orders.AddLast(order); // FIFO
	}

	public void ProcessOrders()
	{
		while (orders.Count > 0)
		{
			IOrder order = orders.First.Value;
			orders.RemoveFirst();
			order.Process();
		}
	}
}
