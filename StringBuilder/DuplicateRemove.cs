//StringBuilder Problem 2: Remove Duplicates from a String Using StringBuilder
//Problem: Write a program that uses StringBuilder to remove all duplicate characters from a
//given string while maintaining the original order.

using System.Text;

internal class DuplicateRemove
{
    internal static string RemovesDuplicateElements(string s)
    {
        //if string is null or emtpy it will return empty string(base case).
        if(s.Length == 0) return string.Empty;

        StringBuilder result = new StringBuilder();

        //hashset is used to remove duplicates from the string.
        HashSet<char> seen = new HashSet<char>();

        foreach (char c in s)
        {
            if (seen.Add(c))   // returns false if already exists
                result.Append(c);
        }

        //result is returned.
        return result.ToString();
    }
}