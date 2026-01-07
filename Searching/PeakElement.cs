using System;

public class PeakElement
{
    // static method to find and return peak in the arr.
    public static int Find(int[] arr)
    {
        //min value is stored in it.
        int max = int.MinValue;
        
        //iteration to find peak
        foreach(int num in arr)
        {
            //conditional check if max is smaller than current num, store num in max.
            if(max < num)
            {
                max = num;
            }
        }

        // return peak value
        return max;
    }
}