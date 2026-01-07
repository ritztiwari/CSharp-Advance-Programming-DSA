//Problem 1: Concatenate Strings Efficiently Using StringBuilder
//Problem: You are given an array of strings. Write a program that uses StringBuilder to
//concatenate all the strings in the array efficiently.

using System.Text;

public class ConcateString
{
    public static string Concate(string[] s)
    {
        // string builder is used to concate.
        StringBuilder str = new StringBuilder();

        //iterations
        foreach(string c in s)
        {
            // appending words to the last string builder
            str.Append(c + " ");
        }

        //result returned
        return str.ToString();
    }
}