//Objective
//Compare the performance of string (O(N2)), StringBuilder (O(N)), and StringBuffer (O(N))
//when concatenating a million strings.
//Approach
//● Using string (Immutable, creates a new object each time)
//● Using StringBuilder (Fast, mutable, thread-unsafe)

using System;
using System.Diagnostics;
using System.Text;

public class StringConcatinationCompare
{
    public static void Compare()
    {
        // number of concatination will be performed;
        const int iterations = 10000;

        // a stop watch to calculate the time taken for the concatination.
        Stopwatch s1 = Stopwatch.StartNew();
        string s = "";

        // looping
        for (int i = 0; i < iterations; i++)
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
        for (int i = 0; i < iterations; i++)
        {
            str.Append('A');
        }

        s2.Stop();
        Console.WriteLine("String Time: " + s2.ElapsedMilliseconds + " ms");
    }
}