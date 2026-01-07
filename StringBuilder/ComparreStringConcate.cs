//Problem 2: Compare StringBuilder Performance
//Problem: Write a program that compares the performance of StringBuilder for
//concatenating strings multiple times.

using System;
using System.Diagnostics;
using System.Text;

public class CompareStringConcate
{
    public static void Compare()
    {
        // number of concatination will be performed;
        const int iterations = 200000;

        // a stop watch to calculate the time taken for the concatination.
        Stopwatch s1 = Stopwatch.StartNew();
        string s = "";

        // looping
        for(int i = 0; i < iterations; i++)
        {
            s += 'A'; 
        }

        //time stopped
        s1.Stop();
        Console.WriteLine("String Time: " + s1.ElapsedMilliseconds + " ms");

        Stopwatch s2 = Stopwatch.StartNew();
        //using stringbuilder to concate.
        StringBuilder str = new StringBuilder();

        //looping
        for(int i = 0; i < iterations; i++)
        {
            str.Append('A');
        }

        s2.Stop();
        Console.WriteLine("String Time: " + s2.ElapsedMilliseconds + " ms");
    }
}