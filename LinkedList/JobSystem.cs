/*Scenario 12: Job Execution System with Executable Interface
Use Case: Background service that executes various jobs like data sync, email alerts, cleanup, etc.
OOP Concepts:
● Interface: Executable allows different jobs to be plugged in.
● LinkedList: Manages job queue.
● Abstraction & Polymorphism: Execute method is uniform, logic varies.*/


using System;
using System.Collections.Generic;

// Executable Interface
interface IExecutable
{
	void Execute();
}

//  Data Sync
class DataSyncJob : IExecutable
{
	public void Execute()
	{
		Console.WriteLine("Executing Data Sync Job");
	}
}

//  Email Alert
class EmailJob : IExecutable
{
	public void Execute()
	{
		Console.WriteLine("Sending Email Alerts");
	}
}

//  Cleanup
class CleanupJob : IExecutable
{
	public void Execute()
	{
		Console.WriteLine("Performing System Cleanup");
	}
}

// Job Queue (Encapsulation)
class JobQueue
{
	private LinkedList<IExecutable> jobs = new();

	public void AddJob(IExecutable job)
	{
		jobs.AddLast(job); // Queue behavior
	}

	public void RunJobs()
	{
		while (jobs.Count > 0)
		{
			IExecutable job = jobs.First.Value;
			jobs.RemoveFirst();
			job.Execute();
		}
	}
}
