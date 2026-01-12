/*LRU(Least Recently Used) Cache System
Use Case: Design an LRU Cache system (as in browsers, OS, etc.) where the most recently accessed item moves to the front.
Why LinkedList? Efficient removal from middle and addition to front when accessed.OOP Concepts:
● Encapsulation: Key - value cache structure is hidden from user.
● Abstraction: Provides simple get() and put() interface.
● Composition: Uses LinkedList +HashMap internally.*/


using System;
using System.Collections.Generic;

class LRUCache
{
	int capacity;
	LinkedList<int> order = new LinkedList<int>();
	Dictionary<int, string> cache = new Dictionary<int, string>();

	public LRUCache(int capacity)
	{
		this.capacity = capacity;
	}

	public string Get(int key)
	{
		if (!cache.ContainsKey(key))
		{
			Console.WriteLine("Not Found");
			return null;
		}

		order.Remove(key);
		order.AddFirst(key);

		return cache[key];
	}

	public void Put(int key, string value)
	{
		if (cache.ContainsKey(key))
		{
			order.Remove(key);
		}
		else if (order.Count == capacity)
		{
			int lru = order.Last.Value;
			order.RemoveLast();
			cache.Remove(lru);
			Console.WriteLine("Removed LRU: " + lru);
		}
		cache[key] = value;
		order.AddFirst(key);
	}
}