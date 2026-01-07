//Binary Search Problem 4: Find the First and Last Occurrence of an Element in a Sorted
//Array
//Problem: Given a sorted array and a target element, write a program that uses Binary Search
//to find the first and last occurrence of the target element in the array.

using System;

public class FirstLast
{
    public static int[] Find(int[] arr,int target)
    {
        // first and last are declared -1.
        int first = -1, last = -1;

        // iteration
        for (int i = 0; i < arr.Length; i++)
        {
            //if target is equal to arr current element and first shouldn't be -1.
            if(arr[i] == target && first != -1)
            {
                last = i;
            }

            //f target is equal to arr current element and first should be -1.
            if (arr[i] == target & first == -1)
            {
                first = last = i;
            }
        }

        // return result.
        return new int[] { first,last};
    }
}