//class - lodical entity , it defines properties (data) and function that object will have
//store value of similar data
//eg : electronics, stationary, human being
//{} ,() , []
using System;

class Student
{
    public int rollno;
    public String name; 
    public String institute;
    public long dob;
    public String branch;
    public Char gender;
    public float height;

    public Student(int r,String n,String i,long d,String b,Char g,float h)

    {
        rollno=r;
        name=n;
        institute=i;
        dob=d;
        branch=b;
        gender=g;
        height=h;
        
    }
    public void display()
    {
        Console.WriteLine(rollno +" " + name +" " + institute +" " + dob +" " + branch +" " + gender +" " + height);
        Console.WriteLine(institute+ " "+height);

    }

}