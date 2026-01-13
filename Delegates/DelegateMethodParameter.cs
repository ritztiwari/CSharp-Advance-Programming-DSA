//Delegate as Method Parameter

//Write a method PerformOperation(int a, int b, DelegateName op)

//Pass different operations using delegates.


public delegate int Operations(int a, int b);

class DelegateMethodParameter
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int PerformOperation(int a, int b, Operations operation)
    {
        return operation(a, b);
    }
}