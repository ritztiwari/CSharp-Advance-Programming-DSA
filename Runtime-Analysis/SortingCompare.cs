//Objective
//Compare sorting algorithms Bubble Sort (O(N2)), Merge Sort (O(N log N)), and Quick Sort
//(O(N log N)).
//Approach
//● Bubble Sort: Repeated swapping(inefficient for large data).
//● Merge Sort: Divide & Conquer approach(stable).
//● Quick Sort: Partition - based approach(fast but unstable).

using System;
using System.Diagnostics;


public class SortingCompare
{
    internal static void Compare(int[] arr)
    {
        Console.WriteLine("comparing starts");

        // to measure the time for sorting, timer started.
        Stopwatch sw = Stopwatch.StartNew();

        BubbleSort(arr);

        //timer stopped.
        sw.Stop();

        Console.WriteLine($"bubble sorting time taken : {sw.ElapsedMilliseconds} ms");

        //reset the stopwatch to zero.
        sw.Reset();

        //timer started again
        sw.Start();

        MergeSort(arr);

        //timer stopped.
        sw.Stop();

        Console.WriteLine($"Merge sorting time taken : {sw.ElapsedMilliseconds} ms");

        //reset the stopwatch to zero.
        sw.Reset();

        //timer started again
        sw.Start();

        QuickSortWrapper(arr);

        //timer stopped.
        sw.Stop();

        Console.WriteLine($"Quick sorting time taken : {sw.ElapsedMilliseconds} ms");
    }

    internal static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void QuickSortWrapper(int[] arr)
    {
        QuickSort(arr, 0, arr.Length - 1);
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low >= high) return;

        int pivot = Partition(arr, low, high);

        QuickSort(arr, low, pivot - 1);
        QuickSort(arr, pivot + 1, high);
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
            if (arr[j] < pivot)
                (arr[++i], arr[j]) = (arr[j], arr[i]);

        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);

        return i + 1;
    }

    internal static void MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return;
        }

        int mid = arr.Length / 2;

        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        Array.Copy(arr, 0, left, 0, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);

        MergeSort(left);
        MergeSort(right);
        Merge(left, right, arr);
    }


    internal static void Merge(int[] left, int[] right, int[] arr)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] < right[j])
            {
                arr[k++] = left[i++];
            }
            else
            {
                arr[k++] = right[j++];
            }
        }

        while (i < left.Length)
        {
            arr[k++] = left[i++];
        }

        while (j < right.Length)
        {
            arr[k++] = right[j++];
        }
    }

}