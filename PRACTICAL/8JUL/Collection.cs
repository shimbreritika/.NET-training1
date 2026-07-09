//Collections - group of objects that can grow or shrink dynamically
//more flexible than array
//list - dynamic array, automatically incr or decr
//dictionary

using System.Collections.Generic;

class Collection
{
    static void Main()
    {
        List<string> name = new List<string>();//create a list of string

        name.Add("Rohit");
        name.Add("Ritika");
        name.Add("Riya");
        name.Add("Mansi");
        name.Add("Nidhi");

        foreach(string f in name) // display all items
        {
            Console.WriteLine(f);
        }  


        /////////////////////
        /// ////
        /// ///
        /// /////
        /// 
        /// 

        List<Stud> st = new List<Stud>
        {
            new Stud {id=1,sname="ritika"},
            new Stud {id=2,sname="riya"},
            new Stud {id=3,sname="rohit"},

        };

        List<Teacher> th = new List<Teacher>
        {
            new Teacher {tid=1,Tname="ritika"},
            new Teacher {tid=2,Tname="riya"},
            new Teacher {tid=3,Tname="rohit"},
        };

        foreach(var stu in st)
        {
            Console.WriteLine("Students : "(stu.sname));
        }

        foreach(var thu in th)
        {
            Console.WriteLine("Teachers : "(thu.Tname));
        
      }
    }

