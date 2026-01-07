//Problem 1: Convert Byte Stream to Character Stream Using StreamReader
//Problem: Write a program that uses StreamReader to read binary data from a file and print
//it as characters.

using System;
using System.IO;

public class ByteToStream
{
    public static void Stream()
    {
        // stream reader to read a file.
        StreamReader reader = new StreamReader("data.txt");

        //an empty integer.
        int ch;

        //iterating through each line in the data.txt
        while ((ch = reader.Read()) != -1)
        {
            //printing the character by character.
            Console.Write((char)ch);
        }
    }
}
