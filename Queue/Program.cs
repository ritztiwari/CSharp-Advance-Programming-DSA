using System;
using System.Net;

internal class Program
{
    internal static void Main(string[] args)
    {
        //PrintJobManager manager = new PrintJobManager();

        //manager.AddJobs(new TextDocument("Project Report"));
        //manager.AddJobs(new ImageFile("Photo.png"));
        //manager.AddJobs(new TextDocument("Resume"));

        //manager.ProcessPrintWork();

        //TicketBookingSystem service = new TicketBookingSystem();

        //service.AddRequest(new Bus("bus101"));
        //service.AddRequest(new Train("train102"));
        //service.AddRequest(new Flight("flight1025"));

        //service.ProcessRequests();

        //CallCenterManagement manager = new CallCenterManagement();

        //manager.AddCalls(new SupportCall());
        //manager.AddCalls(new SupportCall());
        //manager.AddCalls(new SalesCall());
        //manager.AddCalls(new SalesCall());
        //manager.AddCalls(new SupportCall());

        //manager.ProcessCalls();

        TaskDispatcher task = new TaskDispatcher();

        task.AddTask(new Upload());
        task.AddTask(new Upload());
        task.AddTask(new Report());
        task.AddTask(new Report());

        task.HandleTask();
    }
}