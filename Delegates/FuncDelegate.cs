public delegate int Opt(int a, int b);

internal class FuncDelegate
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
    
    public static int PerformOperation(int a,int b,Opt op)
    {
        return op(a, b);
    } 

}
