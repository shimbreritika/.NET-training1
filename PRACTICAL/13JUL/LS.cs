//L - Liskov Substitution principle
// a derived class should be able to replace its base class
//without changing programs correctness



class Bird
{
    public void Fly()
    {
        Console.WriteLine("flyingggg");
    }
}

class Penguin : Bird
{
    public void Fly()
    {
        throw new Exception("Can not fly");
    }
}