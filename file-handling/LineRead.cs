//Problem 1: Read a File Line by Line Using StreamReader
//Problem: Write a program that uses StreamReader to read a text file line by line and print
//each line to the console.

using System.IO;
using System;

public class LineRead
{
    public static void Read()
    {
        // stream reader to read a file.
        StreamReader read = new StreamReader("data.txt");

        //an emtpy string.
        string line;

        //iterating through each line in the data.txt
        while ((line = read.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}
