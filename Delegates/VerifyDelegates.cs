//Delegate for Validation

//Create a delegate that validates:
//Email
//Password
//Phone number

using System;

public delegate bool Check(string s1, string s2);

public class VerifyDelegates
{
    public static bool Email(string s1, string s2)
    {
        return s1.Equals(s2);
    }

    public static bool PhoneNumber(string s1, string s2)
    {
        return s1.Equals(s2);
    }

    public static bool Password(string s1, string s2)
    {
        return s1.Equals(s2);
    }

}