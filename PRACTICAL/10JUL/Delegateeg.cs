//delegate - type that holds a reference to a method
//similiar to Function pointer
//Function - return an values
//display method acts as a pointer
//event based on delegate
//Function is a pre-defines delegate

using System;

//built in delegate func
//Func<int , int , int> add =(a ,b) =>a+b; //lambda expressions
//Console.WriteLine(add(588,745));

delegate void MessageDelegate(string msg);//create a delegate


class Delegateeg
{

    static MessageDelegate m;
    static void Display(string message)
    {
        Console.WriteLine("Method1 :"+message);
    }
    
    static void Display1(string message)
    {
        Console.WriteLine("Method1 :"+message);
    }

    static void Display2(string message)
    {
        Console.WriteLine("Method1 :"+message);
    }


    static void Main()
    {
        m = Display;
        m +=Display1;
        m +=Display2;

        m("Hello , i am learning .NET C#");

        Button bt = new Button();
        bt.Click +=() => Console.WriteLine("Click event");
        bt.Press();

    }
}