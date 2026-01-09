//1.Print Job Manager
//Use Case: Print requests are handled in the order they are received.
//OOP Concepts:
//● Interface: Printable
//● Encapsulation: PrintQueue class hides internal state.
//● Polymorphism: Could be TextDocument, ImageFile, etc.

using System;

interface IPrintable
{
    void Print();
}

class TextDocument : IPrintable
{
    string content;
    
    public TextDocument(string content)
    {
        this.content = content;
    }

    public void Print()
    {
        Console.WriteLine($"printing the text document {content}");
    }
}

class ImageFile : IPrintable
{
    string fileName;
    
    public ImageFile(string fileName)
    {
        this.fileName = fileName;
    }

    public void Print()
    {
        Console.WriteLine($"printing the image {fileName}");
    }
}


class PrintJobManager
{
    Queue<IPrintable> queue = new Queue<IPrintable>();
    
    public void AddJobs(IPrintable job)
    {
        queue.Enqueue(job);
    }

    public void ProcessPrintWork()
    {
        while (queue.Count > 0)
        {
            IPrintable job = queue.Dequeue();
            job.Print();
        }
    }
}