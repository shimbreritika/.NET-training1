
//without generic
class Genricseg
{
void Printt(int number)
{
    Console.WriteLine(number);
}

void Printt1(string namee)
{
    Console.WriteLine(namee);
}
}
//generics - write one class or method that works with diff  data types

class Genericseg<T>
{
    public void Print(T value)
    {
        Console.WriteLine(value);
    }
}