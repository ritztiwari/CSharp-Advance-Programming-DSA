//Objective
//Compare Recursive (O(2^N)) vs Iterative (O(N)) Fibonacci solutions.
//Approach
//Recursive:
//public static int FibonacciRecursive(int n)
//{
//    if (n <= 1) return n;
//    return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
//}

using System;
using System.Diagnostics;

public class FibonacciCompare
{
    public static void Compare(int n)
    {
        //stop watch
        Stopwatch sw = Stopwatch.StartNew();

        int n1 = IterationFibonacci(n);

        sw.Stop();

        // total time taken is printed 
        Console.WriteLine($"total time taken for iterative fibonnaci is : {sw.ElapsedMilliseconds} ms");

        //restart the previous time to zero & start it again.
        sw.Restart();

        int n2 = RecursiveFibonacci(n);

        sw.Stop();

        // total time taken is printed.
        Console.WriteLine($"total time taken for recursive fibonnaci is : {sw.ElapsedMilliseconds} ms");

    }

    //iterative approach
    public static int IterationFibonacci(int n)
    {
        int a = 0;
        int b = 1;

        int sum = 0;

        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }

        return sum;
    }

    //recursive approach
    public static int RecursiveFibonacci(int n)
    {
        if(n <= 1)
        {
            return n;
        }

        return RecursiveFibonacci(n-1) + RecursiveFibonacci(n - 2);
    }
}