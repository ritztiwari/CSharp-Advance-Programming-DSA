//Linear Search Problem 2: Search for a Specific Word in a List of Sentences
//Problem: You are given an array of sentences. Write a program that performs Linear Search
//to find the first sentence containing a specific word.

using System;

internal class WordSearch
{
    public static bool Search(string[] str, string word)
    {
        // iterating through the string array.
        foreach(string c in str)
        {
            //condition check if word is equal to the current array word.
            if(c.Equals(word))
            {
                // return true if it is equal.
                return true; 
            }
        }

        // return false if it is not equal.
        return false;
    } 
}