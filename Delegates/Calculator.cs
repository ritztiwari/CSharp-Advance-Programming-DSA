
//Simple Delegate Invocation

//Create a delegate that takes two integers and returns an integer.

//Implement methods for Add, Subtract, Multiply, and invoke them using the delegate.

using System;

public delegate int Operation(int a, int b);

internal class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}