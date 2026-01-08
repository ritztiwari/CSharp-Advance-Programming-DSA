//1.Search a Target in a Large Dataset
//Objective
//Compare the performance of Linear Search (O(N)) and Binary Search (O(log N)) on different
//dataset sizes.
//Approach
//● Linear Search: Scan each element until the target is found.
//● Binary Search: Sort the data first (O(N log N)), then perform O(log N) search.

using System;
using System.Diagnostics;

public class SearchTargetCompare
{
    public static void SearchCompare(int[] arr,int target)
    {
        //linear search
        Stopwatch sw = Stopwatch.StartNew();

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                break;
            }
        }

        //measuring stopped
        sw.Stop();

        Console.WriteLine($"total time taken to find the target using linear search: {sw.ElapsedMilliseconds} ms");

        // resetted the stopwatch & restarted it.
        sw.Reset();

        sw.Start();

        // binary search the target element.
        int start = 0;
        int end = arr.Length - 1;

        while(start <= end)
        {
            int mid = start + (end - start) / 2;

            if(arr[mid] == target)
            {
                break;
            }
            else if (arr[mid] > target)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }

        sw.Stop();

        Console.WriteLine($"total time taken to find the target using binary search: {sw.ElapsedMilliseconds} ms");
    }
}