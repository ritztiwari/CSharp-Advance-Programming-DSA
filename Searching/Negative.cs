//Linear Search Problem 1: Search for the First Negative Number
//Problem: You are given an integer array. Write a program that performs Linear Search to find
//the first negative number in the array.

using System;

internal class Negative
{
    public static void FindNegative(int[] arr)
    {
        // iterating through the arr.
        foreach(int i in arr){

            //conditional if i is smaller the 0.
            if(i < 0)
            {
                Console.WriteLine($"first negative element is: {i}");
                return;
            }
        }
    }
}