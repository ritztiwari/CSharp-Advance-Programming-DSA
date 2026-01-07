//Binary Search Problem 3: Search for a Target Value in a 2D Sorted Matrix
//Problem: You are given a 2D matrix where each row is sorted in ascending order. Write a
//program that performs Binary Search to find a target value in the matrix.

using System;

public class ElementSearch
{
    public static bool Find(int[,] arr,int target,int rows,int col)
    {
        // iterating through the 2D array.
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < col; j++)
            {
                //if array element is equal to the target then return result.
                if (arr[i,j] == target)
                {
                    return true;
                }
            }
        }

        // return false if array doesn't contain element.
        return false;
    }
}