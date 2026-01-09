//1.Expression Evaluation Engine(Infix to Postfix + Evaluation)
//Use Case: Parse and evaluate mathematical expressions in calculators or compilers.
//OOP Concepts:
//● Interface: ExpressionEvaluator
//● Encapsulation: Stack operations hidden inside evaluator.
//● Polymorphism: Different strategies like PostfixEvaluator, PrefixEvaluator.

using System;
using System.Collections.Generic;

interface IExpressionEvaluator
{
    //interface evaluate method
    double Evaluate(string expression);
}

class PostfixEvaluator : IExpressionEvaluator
{
    //method override.
    public double Evaluate(string expression)
    {
        //calling infixtopostfix
        string postfix = InfixToPostfix(expression);
        return EvaluatePostfix(postfix);
    }

    private string InfixToPostfix(string infix)
    {
        //stack implementation.
        Stack<char> operators = new Stack<char>();
        string output = "";

        foreach (char ch in infix.Replace(" ", ""))
        {
            if (char.IsDigit(ch))
                output += ch;
            else if (ch == '(')
                operators.Push(ch);
            else if (ch == ')')
            {
                while (operators.Peek() != '(')
                    output += operators.Pop();
                operators.Pop();
            }
            else
            {
                while (operators.Count > 0 && Precedence(operators.Peek()) >= Precedence(ch))
                    output += operators.Pop();
                operators.Push(ch);
            }
        }

        while (operators.Count > 0)
            output += operators.Pop();

        return output;
    }

    private double EvaluatePostfix(string postfix)
    {
        Stack<double> stack = new Stack<double>();

        // applying the operator operations and finding the evaluated results.
        foreach (char ch in postfix)
        {
            if (char.IsDigit(ch))
                stack.Push(ch - '0');
            else
            {
                double b = stack.Pop();
                double a = stack.Pop();
                stack.Push(ApplyOperator(a, b, ch));
            }
        }

        return stack.Pop();
    }

    //checks for the precedence of the operators.
    private int Precedence(char op)
    {
        return op == '+' || op == '-' ? 1 :
               op == '*' || op == '/' ? 2 : 0;
    }

    private double ApplyOperator(double a, double b, char op)
    {
        return op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => a / b,
            _ => 0
        };
    }
}
