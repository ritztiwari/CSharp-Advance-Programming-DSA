using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 8, 6, 4, 6, 2, 3, 4, 8 };

        //BubbleSort.Sort(arr);
        //InsertionSort.Sort(arr);
        //SelectionSort.Sort(arr);
        //MergeSort.Sort(arr);
        //QuickSort.quickSort(arr,0,arr.Length-1);
        //CountingSort.CountSort(arr);
        HeapSort.HeapSorting(arr);

        Console.WriteLine(string.Join(",",arr));
    }
}