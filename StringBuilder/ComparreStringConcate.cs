using System;
using System.Diagnostics;
using System.Text;

public class CompareStringConcate
{
    public static void Compare()
    {
        const int iterations = 200000;

        Stopwatch s1 = Stopwatch.StartNew();
        string s = "";

        for(int i = 0; i < iterations; i++)
        {
            s += 'A'; 
        }

        s1.Stop();
        Console.WriteLine("String Time: " + s1.ElapsedMilliseconds + " ms");

        Stopwatch s2 = Stopwatch.StartNew();
        StringBuilder str = new StringBuilder();

        for(int i = 0; i < iterations; i++)
        {
            str.Append('A');
        }

        s2.Stop();
        Console.WriteLine("String Time: " + s2.ElapsedMilliseconds + " ms");
    }
}