//Objective
//Compare StreamReader and FileStream when reading a large file (500MB).
//Approach
//● StreamReader: Reads character by character (slower for binary files).
//● FileStream: Reads bytes and converts to characters (more efficient).

using System;
using System.Diagnostics;
using System.IO;

public class FileReadingCompare
{
    public static void Compare()
    {
        // stopwatch to measure the time taken to do the reading.
        Stopwatch sw = Stopwatch.StartNew();

        //data.txt file path
        string path = @"F:\CSharp-Advance-DSA\Runtime-Analysis\data.txt";

        //methods
        ReadingUsingStreamReader(path);

        sw.Stop();

        Console.WriteLine($"time taken using stream reader: {sw.ElapsedMilliseconds} ms");

        sw.Restart();

        //methods
        ReadingUsingFileStream(path);

        //stop the time measuring now.
        sw.Stop();

        Console.WriteLine($"total time taken: {sw.ElapsedMilliseconds} ms");
    }

    public static void ReadingUsingStreamReader(string path)
    {
        //object creation to read the file content.
        StreamReader reader = new StreamReader(path);

        int ch;

        while((ch = reader.Read()) != -1){
            // reading character by character
            //print the statement here
        }
    }

    public static void ReadingUsingFileStream(string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[1024 * 1024]; // 1MB buffer
            while (fs.Read(buffer, 0, buffer.Length) > 0) 
            {
                // reading byte by byte here
                // print the file contents.
            }
        }
    }
}
