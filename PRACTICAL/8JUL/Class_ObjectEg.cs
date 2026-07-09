//object - physical entity ,uses class properties and functions

using System;

class Class_ObjectEg
{
    static void Main()
    {
    
        //collecting data 
        Student student = new Student(12,"Ritika","SSGMCE,Shegaon",19900101,"IT",'F',5.4f); //obj creation
        //student.rollno=12;
        //student.name="Ritika";
        //student.institute="SSGMCE,Shegaon";
        //student.dob=19900101;
        //student.branch="IT";
       

        student.display(); //calling function
    }
}
