//StringBuilder Problem 1: Reverse a String Using StringBuilder
//Problem: Write a program that uses StringBuilder to reverse a given string. For example, if
//the input is "hello", the output should be "olleh".

using System.Text; 

internal class ReverseString
{
    public static string reverseString(string s)
    {
        // base cases
        if (s == null) return "";

        if (s.Length == 1) return s;

        StringBuilder str = new StringBuilder();

        //iterating through the string in reverse order and storing it into the string builder.
        for(int i = s.Length-1; i >= 0; i--)
        {
            str.Append(s[i]);
        }

        //result returned to the main class.
        return str.ToString();
    } 
}