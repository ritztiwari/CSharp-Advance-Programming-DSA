//4.Task Dispatcher for Background Workers
//Use Case: Queue tasks like file uploads, analytics, or logs to background workers.
//OOP Concepts:
//● Interface: BackgroundTask
//● Encapsulation: TaskQueue shields queue logic.
//● Polymorphism: Different tasks(upload, report) use same interface.

using System;

interface IBackgroundTask
{
    void Dispatch();
}

class Upload : IBackgroundTask
{
    public void Dispatch()
    {
        Console.WriteLine($"upload is handled");
    }
}

class Report : IBackgroundTask
{
    public void Dispatch()
    {
        Console.WriteLine($"report is handled");
    }
}

class TaskDispatcher
{
    Queue<IBackgroundTask> queue = new Queue<IBackgroundTask>();

    public void AddTask(IBackgroundTask task)
    {
        queue.Enqueue(task);
    }

    public void HandleTask()
    {
        while(queue.Count > 0 )
        {
            IBackgroundTask request = queue.Dequeue();
            request.Dispatch();
        }
    }
}