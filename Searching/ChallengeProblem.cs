//Problem:
//You are given a list of integers. Write a program that uses Linear Search to find the first
//missing positive integer in the list and Binary Search to find the index of a given target
//number.
//Approach:
//1.Linear Search for the first missing positive integer:
//o Iterate through the list and mark each number in the list as visited (you can
//use negative marking or a separate array).
//o Traverse the array again to find the first positive integer that is not marked.
//2. Binary Search for the target index:
//o After sorting the array, perform binary search to find the index of the given
//target number.
//o Return the index if found, otherwise return -1.

using System;


public class ChallengeProblem
{
    public static int MissingValue(int[] arr)
    {
        int n = arr.Length;

        // Step 1: Clean the array
        for (int i = 0; i < n; i++)
        {
            if (arr[i] <= 0 || arr[i] > n)
                arr[i] = n + 1;
        }

        // Step 2: Mark visited numbers
        for (int i = 0; i < n; i++)
        {
            int val = Math.Abs(arr[i]);

            if (val >= 1 && val <= n)
                arr[val - 1] = -Math.Abs(arr[val - 1]);
        }

        // Step 3: Find first unmarked index
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0)
                return i + 1;
        }

        return n + 1;
    }

    public static int Contains(int[] arr,int target)
    {
        // start and end fields are generator for iteration.
        int left = 0;
        int right = arr.Length - 1;

        // looping
        while (left <= right)
        {
            // mid variable store middle value.
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                //returns number.
                return mid;

            if (arr[mid] < target)
                left = mid + 1;

            else
                right = mid - 1;
        }

        // returns -1 if not found.
        return -1;
    }
}