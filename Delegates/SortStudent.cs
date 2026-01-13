//Delegate for Sorting

//Use a delegate to sort a list of students based on:

//Name
//Marks
//Age


public class Student
{
	public string Name { get; private set; }
	public int Marks { get; private set; }
	public int Age { get; private set; }

	public Student(string name, int marks, int age)
	{
		Name = name;
		Marks = marks;
		Age = age;
	}
}

public delegate int StudentComparison(Student s1, Student s2);

public class SortStudent
{
	public static int SortByName(Student a, Student b)
		=> a.Name.CompareTo(b.Name);

	public static int SortByAge(Student a, Student b)
		=> b.Age.CompareTo(a.Age);

	public static int SortByMarks(Student a, Student b)
		=> b.Marks.CompareTo(a.Marks);
}
