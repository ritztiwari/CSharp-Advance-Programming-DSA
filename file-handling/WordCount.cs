//Problem 2: Count the Occurrence of a Word in a File Using StreamReader
//Problem: Write a program that reads a file and counts how many times a specific word
//appears in the file.

using System;
using System.IO;
using System.Text.RegularExpressions;

public class WordCount
{
	public static int Count(string word) 
	{
		//stream reader to read the file.
		StreamReader reader = new StreamReader("data.txt");

		//count to store the no. of times word occured in the file.
		int count = 0;
		string line;

		//looping through the line by line
		while ((line = reader.ReadLine()) != null)
		{
			//using regex to find the count word. 
			count += Regex.Matches(line, $@"\b{Regex.Escape(word)}\b", RegexOptions.IgnoreCase).Count;
		}

		//return count
		return count;
	}
}
