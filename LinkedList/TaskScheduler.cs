/*Scenario 6: Task Scheduler with Prioritization
Use Case: A system schedules tasks based on priority, dynamically updating the task queue.
Why LinkedList? Enables dynamic insertion at any position (based on priority).
OOP Concepts:
● Encapsulation: Task data is wrapped securely.
● Abstraction: Methods hide complexity of inserting tasks by priority.
● Polymorphism: Tasks can be of different types (EmailTask, ReportTask).*/


using System;
using System.Collections.Generic;

namespace TaskSchedulerScenario
{
	// Base Task (Polymorphism)
	public abstract class TaskBase
	{
		public string Description { get; }
		public int Priority { get; }

		protected TaskBase(string desc, int prio)
		{
			Description = desc;
			Priority = prio;
		}

		public abstract void Execute();
	}

	// Email Task
	public class EmailTask : TaskBase
	{
		public EmailTask(string desc, int prio) : base(desc, prio) { }

		public override void Execute()
		{
			Console.WriteLine($"[Email] Executing: {Description}");
		}
	}

	// Report Task
	public class ReportTask : TaskBase
	{
		public ReportTask(string desc, int prio) : base(desc, prio) { }

		public override void Execute()
		{
			Console.WriteLine($"[Report] Executing: {Description}");
		}
	}

	// Scheduler (Encapsulation + Abstraction)
	public class TaskScheduler
	{
		private LinkedList<TaskBase> tasks = new();

		// Add task in priority order (lower number = higher priority)
		public void AddTask(TaskBase task)
		{
			if (tasks.Count == 0)
			{
				tasks.AddFirst(task);
				Console.WriteLine($"Task Added: {task.Description} (Priority {task.Priority})");
				return;
			}

			var current = tasks.First;
			while (current != null && current.Value.Priority <= task.Priority)
				current = current.Next;

			if (current == null)
				tasks.AddLast(task);
			else
				tasks.AddBefore(current, task);

			Console.WriteLine($"Task Added: {task.Description} (Priority {task.Priority})");
		}

		public void ExecuteNext()
		{
			if (tasks.Count == 0)
			{
				Console.WriteLine("No tasks to execute.");
				return;
			}

			TaskBase next = tasks.First.Value;
			tasks.RemoveFirst();
			next.Execute();
		}
	}
}
