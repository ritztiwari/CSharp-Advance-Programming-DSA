//Anonymous Method with Delegate

//Use an anonymous method to calculate the square of a number using a delegate.

public delegate int Sqaures(int n);

internal class Calci
{
    public static int Sqaure(int n)
    {
        return n * n;
    }
}