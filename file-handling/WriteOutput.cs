//Problem 2: Read User Input and Write to File Using StreamReader
//Problem: Write a program that reads user input from the console and writes it to a file.

using System;
using System.IO;

public class WriteOutput
{
    public static void Out()
    {
        Console.WriteLine("enter the string to input and store in the output.txt");

        //stream writer 
        using StreamWriter writer = new StreamWriter("Output.txt");

        // looping to take input from user and write into the output.txt file.
        while (true)
        {
            //input from user.
            string input = Console.ReadLine();

            // edge case to exit the loop.
            if (input.ToLower() == "exit")
            {
                break;
            }

            //write it into the output file.
            writer.WriteLine(input);
        }
        Console.WriteLine("finished");
    } 
}
