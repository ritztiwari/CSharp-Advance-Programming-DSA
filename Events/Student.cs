//Custom EventArgs

//Create a Student class that raises an event when marks change.

//Pass:
//Old Marks
//New Marks
//Use a custom EventArgs class.

using System;

internal class Student
{
	private int marks;

	public event EventHandler<MarksChangedEventArgs> MarksChanged;

	public int Marks
	{
		get { return marks; }

		set
		{
			if (marks != value)
			{
				int old = marks;
				marks = value;

				OnMarksChanged(old, marks);
			}
		}
	}

	protected virtual void OnMarksChanged(int oldMarks, int newMarks)
	{
		MarksChanged?.Invoke(this, new MarksChangedEventArgs(oldMarks, newMarks));
	}
}

class MarksChangedEventArgs : EventArgs
{
	public int OldMarks { get; }
	public int NewMarks { get; }

	public MarksChangedEventArgs(int oldMarks, int newMarks)
	{
		OldMarks = oldMarks;
		NewMarks = newMarks;
	}
}


	