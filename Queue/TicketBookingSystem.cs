//2.Ticket Booking System Queue
//Use Case: Ticket requests(flight, train) are processed in sequence.
//OOP Concepts:
//● Interface: TicketRequest
//● Encapsulation: Request queue managed inside a service.
//● Abstraction & Polymorphism: Works for bus/train/flight with common interface.

using System;

interface ITicketRequest
{
    void GetTicket();
}

class Bus : ITicketRequest
{
    string ticket;

    public Bus(string ticket)
    {
        this.ticket = ticket;
    }

    public void GetTicket()
    {
        Console.WriteLine($"bus ticket is generated: {ticket}");
    }
}

class Train : ITicketRequest
{
    string ticket;

    public Train(string ticket)
    {
        this.ticket = ticket;
    }

    public void GetTicket()
    {
        Console.WriteLine($"train ticket is generated: {ticket}");
    }
}

class Flight : ITicketRequest
{
    string ticket;

    public Flight(string ticket)
    {
        this.ticket = ticket;
    }

    public void GetTicket()
    {
        Console.WriteLine($"flight ticket is generated: {ticket}");
    }
}

class TicketBookingSystem
{
    Queue<ITicketRequest> queue = new Queue<ITicketRequest>();

    public void AddRequest(ITicketRequest request)
    {
        queue.Enqueue(request);
    }

    public void ProcessRequests()
    {
        while (queue.Count > 0)
        {
            ITicketRequest request = queue.Dequeue();
            request.GetTicket();
        }
    }

}