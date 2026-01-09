//3.Syntax Checker for Code Editors
//Use Case: Validate matched parentheses, brackets, or braces ({}, [], ()).
//OOP Concepts:
//● Interface: SyntaxChecker
//● Encapsulation: Stack logic is hidden inside the implementation.
//● Polymorphism: Can create multiple syntax checkers for different file types.

using System;

interface ISyntaxChecker
{
    bool CheckParenthesis(string str);
}

class ValidParenthesis : ISyntaxChecker
{
    //overrides the checkparenthesis of the interface in the class.
    public bool CheckParenthesis(string str)
    {
        Stack<char> stack = new Stack<char>();

        //iterating through the string
        foreach (char ch in str)
        {
            if (ch == '(' || ch == '[' || ch == '{')
            {
                stack.Push(ch);
            }
            else if (ch == ')' || ch == ']' || ch == '}')
            {
                if (stack.Count == 0)
                    return false;

                char open = stack.Pop();

                //checking the if parenthesis is matching or not.
                if (!IsMatchingPair(open, ch))
                    return false;
            }
        }

        return stack.Count == 0;
    }

    public bool IsMatchingPair(char open, char close)
    {
        return (open == '(' && close == ')') ||
               (open == '[' && close == ']') ||
               (open == '{' && close == '}');
    }
}