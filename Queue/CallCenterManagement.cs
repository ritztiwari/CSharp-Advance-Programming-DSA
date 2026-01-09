//5.Call Center Management System
//Use Case: Incoming calls are queued for available agents.
//OOP Concepts:
//● Interface: CallRequest
//● Polymorphism: Calls could be SupportCall, SalesCall, etc.
//● Encapsulation: Queue handling hidden inside CallCenterManager.

using System;

interface ICallRequest
{
    void AttendCalls();
}

class SupportCall : ICallRequest
{
    public void AttendCalls()
    {
        Console.WriteLine("support call attended");
    }
}

class SalesCall : ICallRequest
{
    public void AttendCalls()
    {
        Console.WriteLine("sales call attended");
    }
}

internal class CallCenterManagement
{
    Queue<ICallRequest> queue = new Queue<ICallRequest>();

    public void AddCalls(ICallRequest request)
    {
        queue.Enqueue(request);
    }

    public void ProcessCalls()
    {
        while (queue.Count > 0) 
        {
            ICallRequest request = queue.Dequeue();
            request.AttendCalls();
        }
    }
}