using System;

internal class Program
{
    internal static void Main(string[] args)
    {
        //string s = Console.ReadLine() ?? "";
        //Console.WriteLine(ReverseString.reverseString(s));

        //Console.WriteLine(DuplicateRemove.RemovesDuplicateElements(s));

        //int[] arr = { 1, 2, 3, 4, -5, 66, 5, 8, 3 };

        //string[] str = {"rishabh","kumar","tiwari"};

        //Console.WriteLine(WordSearch.Search(str, "tiwari"));

        //arr declaration 
        //int[] arr = new int[5] { 52,42,5,186,45 };

        //max element print in the array.
        //Console.WriteLine(PeakElement.Find(arr));

        //int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 45, 22, 43 }, { 56, 44, 56 } };

        //Console.WriteLine(ElementSearch.Find(arr,99,3,3));

        //int[] arr = new int[] { 52,42,5,5,5,186,45 };

        //int[] value = FirstLast.Find(arr, 5);

        //Console.WriteLine(string.Join(",", value));

        //int[] arr = new int[] {1,5,5,8,-12,15,84,96};
        //Negative.Find(arr);

        //int[] arr = new int[] {1,5,5,8,9,12,15,84,96};

        //Console.WriteLine(ChallengeProblem.Contains(arr, 12));

        //Console.WriteLine(ChallengeProblem.MissingValue(arr));

        int[] arr = { 4, 5, 6, 7, 0, 1, 2 };

        int index = RotationPointFinder.FindRotationIndex(arr);

        Console.WriteLine("Rotation Point Index: " + index);
        Console.WriteLine("Smallest Element: " + arr[index]);


        //Console.ReadKey();
    }
}