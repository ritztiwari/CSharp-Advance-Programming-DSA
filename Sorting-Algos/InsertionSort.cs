using System;

public class InsertionSort
{
    public static void Sort(int[] arr)
    {
        // iterating through the array.
        for(int i = 1;i<arr.Length; i++)
        {
            //defining the current element.
            int key = arr[i];
            int j = i - 1;

            //comparing the key should be greator than current element to swap.
            while(j >= 0 && arr[j] > key)
            {
                arr[j+1] = arr[j];
                j--;
            }

            // if not then just store the key into the arr next element.
            arr[j+1] = key;
        }
    }
}