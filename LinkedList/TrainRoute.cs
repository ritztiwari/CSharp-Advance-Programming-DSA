/*Train Route Management System
Use Case: A railway system manages stations as linked stops in a train's route. You can dynamically insert, remove, or reverse the route.
Why LinkedList? Allows dynamic insertion/removal of stations and easy traversal of the route.
OOP Concepts:
● Encapsulation: Each route is encapsulated in its own class.
● Abstraction: Public methods like addStation(), removeStation() hide internal pointer logic.
● Inheritance: Could extend Route for special trains (Express, Freight).
● Polymorphism: You can override travel rules for different train types.*/


using System;
using System.Collections.Generic;

// Base Route Class (Abstraction + Polymorphism)
public class Route
{
	protected LinkedList<string> stations = new LinkedList<string>();

	public virtual void AddStation(string station)
	{
		stations.AddLast(station);
		Console.WriteLine($"Station Added: {station}");
	}

	public virtual void RemoveStation(string station)
	{
		if (stations.Remove(station))
			Console.WriteLine($"Station Removed: {station}");
		else
			Console.WriteLine("Station not found.");
	}

	public virtual void ShowRoute()
	{
		Console.Write("Train Route: ");
		foreach (var station in stations)
			Console.Write(station + " -> ");
		Console.WriteLine("END");
	}

	public virtual void ReverseRoute()
	{
		LinkedList<string> reversed = new LinkedList<string>();
		foreach (var station in stations)
			reversed.AddFirst(station);

		stations = reversed;
		Console.WriteLine("Route Reversed");
	}
}

// Express Route (Inheritance + Polymorphism)
public class ExpressRoute : Route
{
	public override void AddStation(string station)
	{
		// Express trains stop at fewer stations
		if (stations.Count < 6)
			base.AddStation(station);
		else
			Console.WriteLine("Express route cannot add more stations.");
	}
}
