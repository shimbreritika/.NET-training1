//I - interface segregation principle
//clients should not be forced to implement methods they do not 


interface Program
{
    void work();
    void walk();

}
interface Program1
{
    void eat();
}

class Human : Program , Program1
{
    public void work()
    {
        
    }
    public void walk()
        {
    }
    public void eat()
    {
        
    }
}

class Robot : Program
{
    public void work()
    {
        
    }
    public void walk()
        {
    }
    public void eat()
    {
        
    }
}