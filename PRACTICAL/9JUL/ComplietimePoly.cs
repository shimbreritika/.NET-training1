//suppose an API allows searching in diffferent ways
//search method is same but parameters will change
// same method , different parameters
//compiler decides which mehod to call
using System;

class ComplietimePoly
{
    public void Search(int id)
    {
        Console.WriteLine("Search by Employee id");

    }

    public void Search(string firstNmae , string lastName)
    {
        Console.WriteLine("Search by name");

    }

    public void Search(long phone)
    {
        Console.WriteLine("Wearch by phone");
        
    }
}
