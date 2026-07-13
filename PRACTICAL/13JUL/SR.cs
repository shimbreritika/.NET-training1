//SOLID principle
//s - single responsilbility (SRP)
//a class should have only one reason to change , it should 
//perform only one responsiblity


//calculate invoice, print invoice, save invoice

class SR
{
    public void CalculateTotal()
    {
        Console.WriteLine("Calculate total");
    }

    public void PrintInvoice()
    {
        Console.WriteLine("Print Invoice");
    }

    public void SaveToDB()
    {
        Console.WriteLine("Saving Invoice");
    }
}
