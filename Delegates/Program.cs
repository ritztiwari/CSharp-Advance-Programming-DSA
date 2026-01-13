using System;
using System.ComponentModel;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Program
{
    public static void Main(string[] args)
    {
        //Operation op;

        //op = Calculator.Add;
        //Console.WriteLine("Addition: " + op(10, 5));

        //op = Calculator.Subtract;
        //Console.WriteLine("Subtraction: " + op(10, 5));

        //op = Calculator.Multiply;
        //Console.WriteLine("Multiplication: " + op(10, 5));

        //Message ms;

        //ms = PrintMessage.WelcomeMessage;
        //ms("rishabh");
        //ms = PrintMessage.ErrorMessage;
        //ms("outofbounderror");
        //ms = PrintMessage.SuccessMessage;
        //ms("rishabh");

        //int result1 = DelegateMethodParameter.PerformOperation(10, 5, Calculator.Add);
        //Console.WriteLine("Addition: " + result1);

        //int result2 = DelegateMethodParameter.PerformOperation(10, 5, Calculator.Subtract);
        //Console.WriteLine("Subtraction: " + result2);

        //int result3 = DelegateMethodParameter.PerformOperation(10, 5, Calculator.Multiply);
        //Console.WriteLine("Multiplication: " + result3);

        //Greetings gr;

        //gr = MulticastDelegate.Afternoon;
        //gr += MulticastDelegate.Morning;
        //gr += MulticastDelegate.Night;
        //gr();

        //Sqaures op;

        //op = Calci.Sqaure;
        //int result = op(5);
        //Console.WriteLine(result);

        //int result1 = FuncDelegate.PerformOperation(10, 5, FuncDelegate.Add);
        //Console.WriteLine("Addition: " + result1);

        //int result2 = FuncDelegate.PerformOperation(10, 5, FuncDelegate.Subtract);
        //Console.WriteLine("Subtraction: " + result2);

        //int result3 = FuncDelegate.PerformOperation(10, 5, FuncDelegate.Multiply);
        //Console.WriteLine("Multiplication: " + result3);

        //Check ch;

        //ch = VerifyDelegates.Email;
        //bool result = ch("mrishabh532@gmail.com", "mrishabh53@gmail.com");
        //Console.WriteLine(result);

        //ch = VerifyDelegates.PhoneNumber;
        //bool result1 = ch("8595435565", "8595435565");
        //Console.WriteLine(result1);

        //ch = VerifyDelegates.Email;
        //bool result2 = ch("rishabh123", "rishabh123");
        //Console.WriteLine(result2);

        //Notify notifier = NotificationService.SendEmail;
        //notifier += NotificationService.SendSMS;
        //notifier += NotificationService.SendPush;

        //Console.WriteLine("All notifications:");
        //notifier();

        //// Remove one method at runtime
        //notifier -= NotificationService.SendSMS;

        //Console.WriteLine("\nAfter removing SMS:");
        //notifier();

        //FileDownloader.DownloadFile("Report.pdf", FileDownloader.OnDownloadCompleted);

        List<Student> students = new List<Student>
        {
            new Student("Rohit", 85, 21),
            new Student("Aman", 92, 20),
            new Student("Neha", 88, 22)
        };

        students.Sort(SortStudent.SortByName);
        Display("Sorted by Name", students);

        students.Sort(SortStudent.SortByMarks);
        Display("Sorted by Marks", students);

        students.Sort(SortStudent.SortByAge);
        Display("Sorted by Age", students);

    }

        public static void Display(string title,List<Student> students)
        {
        Console.WriteLine(title);
            foreach (var s in students)
            {
                Console.WriteLine($"{s.Name} | {s.Marks} | {s.Age}");
            }
        }

    }