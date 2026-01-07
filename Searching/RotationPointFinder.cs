//Binary Search Problem 1: Find the Rotation Point in a Rotated Sorted Array
//Problem: You are given a rotated sorted array. Write a program that performs Binary Search
//to find the index of the smallest element in the array.

using System;

class RotationPointFinder
{
    public static int FindRotationIndex(int[] arr)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] > arr[high])
                low = mid + 1;
            else
                high = mid;
        }

        return low;   // index of smallest element
    }
}