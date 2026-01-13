//Callback using Delegate
//Simulate a file download method that accepts a delegate as a callback to notify when download completes.

using System;
using System.Threading;

public delegate void DownloadCompleted(string fileName);

public class FileDownloader
{
    public static void DownloadFile(string fileName, DownloadCompleted callback)
    {
        Console.WriteLine($"Downloading {fileName}...");

        // Simulate time-consuming download
        Thread.Sleep(2000);

        Console.WriteLine("Download finished.");
        callback(fileName);
    }

    public static void OnDownloadCompleted(string fileName)
    {
        Console.WriteLine($"Callback: {fileName} downloaded successfully.");
    }
}