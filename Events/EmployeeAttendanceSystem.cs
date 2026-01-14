//Employee Attendance System

//Raise an event when employee checks in late.

using System;

class LateCheckInEventArgs : EventArgs
{
    public string EmployeeName { get; }
    public DateTime CheckInTime { get; }

    public LateCheckInEventArgs(string name, DateTime time)
    {
        EmployeeName = name;
        CheckInTime = time;
    }
}

class EmployeeAttendanceSystem
{
    public string Name { get; }

    private static readonly TimeSpan OfficeStartTime = new TimeSpan(9, 0, 0);

    public event EventHandler<LateCheckInEventArgs> LateCheckedIn;

    public EmployeeAttendanceSystem(string name)
    {
        Name = name;
    }

    public void CheckIn(DateTime time)
    {
        if (time.TimeOfDay > OfficeStartTime)
        {
            OnLateCheckedIn(time);
        }
        else
        {
            Console.WriteLine($"{Name} checked in on time at {time.TimeOfDay}");
        }
    }

    protected virtual void OnLateCheckedIn(DateTime time)
    {
        LateCheckedIn?.Invoke(this, new LateCheckInEventArgs(Name, time));
    }
}