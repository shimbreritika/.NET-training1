//async - needed for operations which take sometime 
//without async, the application waits until the work finishes 


using System;
using System.Threading.Tasks;

public class AsyncAwaitt
{
    static async Task Main()
    {
        Console.WriteLine("Loading empolyee data details......");

        await LoadEmployee();

        Console.WriteLine("Completed");
    }

    static async Task LoadEmployee()
    {
        await Task.Delay(3000);

        Console.WriteLine("Employee loaded");
        
    }
}