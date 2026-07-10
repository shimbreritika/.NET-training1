//exception handling prevents a program crashing when error occurs
//try - risky code 
//catch(Exception e) - handle exception
//finally - always executes

using System;

class Exceptioneg
{
    static void CheckAge(int age)
    {
        if(age<20)
        {
            throw new Exception("Not eligible for placement drive");
        }
        Console.WriteLine("Can attend placement drive");
    }
    static void Main()
    {
        try
        {
            int a=50;
            int b=10;
            int c=a/b;
            Console.WriteLine(c); //5
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            CheckAge(25);
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    
    }
}