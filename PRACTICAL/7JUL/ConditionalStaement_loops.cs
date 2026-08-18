using System;

class ConditionalStaement_loops
{
    static void Main(string[] args)
    {
        //conditional staements - allow program to make decisions based on certain conditions
        //if - executes a block of code if condition is TRUE
        // if else
        //if else - executes one block if condition is TRUE
        bool prgramBasic = true;

        if (prgramBasic == true)
        {
            Console.WriteLine("Eligible for learning dot net course");
        }
        else
        {
            Console.WriteLine("Not Eligible as basic programming is not known");
        }

        //if else if else - checks multiple conditions
        // if else if else
        int marks = 78;

        if (marks > 90)
        {
            Console.WriteLine("You are not eligible.");
        }
        else if (marks >= 80)
        {
            Console.WriteLine("Grade = A");
        }
        else if (marks >= 70)
        {
            Console.WriteLine("Grade = B");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade = C");
        }
        else if (marks >= 40)
        {
            Console.WriteLine("Grade = D");
        }
        else
        {
            Console.WriteLine("Fail");
        }
         
        //switch - used when there are multiple possible values for a single variable


        //loops - executes  a block of code repeatedly 
        //for - used when the number of iterations is known

        // for loop
        for (int studentCount = 1; studentCount <= 37; studentCount++)
        {
            Console.WriteLine(studentCount);
        }

        //while - executes while the conditions is true
        // while loop
        int scount = 1;

        while (scount <= 40)
        {
            Console.WriteLine(scount);
            scount++;
        }

        //do while - executes the loop body at least once, even if condition is false
        // do while
        int s = 41;

        do
        {
            Console.WriteLine(s);
            s++;
        }
        while (s <= 40);

        //break - terminates the loop immediatedly
        // break
        for (int studentCount = 1; studentCount <= 37; studentCount++)
        {
            if (studentCount == 20)
            {
                break;
            }

            Console.WriteLine(studentCount);
        }

        //continue - skips the current iteration and continues with the next iteration
        // continue
        for (int studentCount = 1; studentCount <= 37; studentCount++)
        {
            if (studentCount == 10)
            {
                continue;
            }

            Console.WriteLine(studentCount);
        }
    }
}