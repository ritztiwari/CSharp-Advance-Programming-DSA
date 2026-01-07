using System;

public class BubbleSort
{
    public static void Sort(int[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < arr.Length-i-1; j++)
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
}