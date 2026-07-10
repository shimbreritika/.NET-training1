//events - based on delegate and use to notify other classes when something happens 
using System;

class Button
{
    public event Action Click;

    public void Press()
    {
        Console.WriteLine("Button id pressed");
        Click?.Invoke();
    }
}