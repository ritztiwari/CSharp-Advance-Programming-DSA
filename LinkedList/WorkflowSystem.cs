/*Scenario 16: Workflow Engine with Dynamic Steps
Use Case: A document approval workflow system executes multiple steps (validate, review,approve) in sequence.
Why LinkedList? Each step is a node; can be dynamically inserted/removed.
OOP Concepts:
● Interface: WorkflowStep defines a step.
● Polymorphism: Steps vary but follow same interface.
● Abstraction & Encapsulation: Workflow logic is hidden from the user.*/


using System;
using System.Collections.Generic;

// Interface for Workflow Steps
interface IWorkflowStep
{
	void Execute();
}

// Validate Step
class ValidateStep : IWorkflowStep
{
	public void Execute()
	{
		Console.WriteLine("Executing Validation Step");
	}
}

// Review Step
class ReviewStep : IWorkflowStep
{
	public void Execute()
	{
		Console.WriteLine("Executing Review Step");
	}
}

// Approve Step
class ApproveStep : IWorkflowStep
{
	public void Execute()
	{
		Console.WriteLine("Executing Approval Step");
	}
}

// Workflow Engine (Encapsulation)
class WorkflowEngine
{
	private LinkedList<IWorkflowStep> steps = new();

	public void AddStep(IWorkflowStep step)
	{
		steps.AddLast(step);
	}

	public void RunWorkflow()
	{
		foreach (var step in steps)
		{
			step.Execute();
		}
	}

	public void RemoveStep(IWorkflowStep step)
	{
		steps.Remove(step);
	}
}
