using System;

internal class CountingSort
{
    public static int[] CountSort(int[] arr)
    {
        int n = arr.Length;
        if (n == 0)
        {
            return new int[0];
        }

        // find maximum
        int maxVal = arr[0];
        foreach (int v in arr)
        {
            if (v > maxVal)
                maxVal = v;
        }

        // create and initialize cntArr
        int[] cntArr = new int[maxVal + 1];
        for (int i = 0; i <= maxVal; i++)
        {
            cntArr[i] = 0;
        }

        // count frequency
        foreach (int v in arr)
        {
            cntArr[v]++;
        }

        // prefix sums
        for (int i = 1; i <= maxVal; i++)
        {
            cntArr[i] += cntArr[i - 1];
        }

        // build output
        int[] ans = new int[n];
        for (int i = n - 1; i >= 0; i--)
        {
            int v = arr[i];
            ans[cntArr[v] - 1] = v;
            cntArr[v]--;
        }

        return ans;
    }
}