using System;

internal class Program 
{
    internal static void Main(string[] args)
    {
        IExpressionEvaluator evaluator = new PostfixEvaluator();

        string expr = "(8+2*6)*2";
        double result = evaluator.Evaluate(expr);

        Console.WriteLine("Result: " + result);

        //DrawingApp app = new DrawingApp();
        //app.DoTheDrawing(new DrawLine());
        //app.DoTheDrawing(new Erase());
        //app.DoTheDrawing(new DrawCircle());
        //app.Undo();
        //app.Undo();

        //INavigationManager tab = new NavigationManager();
        //tab.OpenTab("www.google.com");
        //tab.OpenTab("www.Netflix.com");
        //tab.OpenTab("www.Facebook.com");
        //tab.OpenTab("www.Chatgpt.com");
        //tab.CurrentTab();
        //tab.GoBackward();
        //tab.GoBackward();
        //tab.GoForward();
        //tab.CurrentTab();

        //ISyntaxChecker obj = new ValidParenthesis();
        //Console.WriteLine("Give parentheses notation: ");
        //string str = Console.ReadLine() ?? "";
        //bool result = obj.CheckParenthesis(str);
        //Console.Write(result);

    }
}