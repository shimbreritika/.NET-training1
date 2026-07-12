using System;
using System.Collections.Generic;
using System.Transactions;


Genericseg<int> n = new Genericseg<int>();
n.Print(100);

Genericseg<string> n1 = new Genericseg<string>();
n1.Print("Ritika");

Genericseg<double> n2 = new Genericseg<double>();
n2.Print(100.35);

String empName = "RITIKA";
Console.WriteLine(empName.ProperCase());  //Ritika
string empName1="MANSI";
Console.WriteLine(empName1.ProperCase());


class Programeg
{  
    static void Main()
    {
    
    List<Employee> employees=new List<Employee>();
    List<Manager> managers= new List<Manager>();

        while(true)
        {
            Console.WriteLine("Welcome to Emp System");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Add Mangers");
            Console.WriteLine("3. View Employee");
            Console.WriteLine("4. View Managers");
            Console.WriteLine("5. Search Employee by id");
            Console.WriteLine("6. Exit");

            Console.Write("Enter choice 1-6 :");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1: 
                       Console.Write("Enter id : ");
                       int id= Convert.ToInt32(Console.ReadLine());
                       bool exists = false;
                       foreach(Employee emp in employees)
                        {
                            if(emp.Id==id)
                            {
                                exists = true;
                                break;
                            }
                        }if(exists)
                        {
                            Console.WriteLine("Employee id aleardy exists");
                            break;
                        }
                        Console.Write("Enter name : ");
                        string name= Console.ReadLine();
                        Console.Write("Enter.Salary:");
                        double salary= Convert.ToDouble(Console.ReadLine());
                        Employee employee= new Employee(id,name , salary);


                        //add in collection
                        employees.Add(employee);
                        Console.WriteLine("Empolyee addes succesfully");
                        break;
                    case 2 :
                        Console.Write("Enter Manger ID");
                        int mid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter name :");
                        string mname =  Console.ReadLine();
                        Console.Write("Enter.Salary:");
                        double msalary= Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter dept : ");
                        string mdept=Console.ReadLine();
                        Manager manager= new Manager(mid,mname,msalary ,mdept);
                        managers.Add(manager);
                        Console.WriteLine("Manger added successfully");
                        break;

                    case 3 :
                        if (employees.Count==0)
                        {
                            Console.WriteLine("No empolyee in system");
                        }
                        else
                        {
                            foreach(Employee emp in employees)
                            {
                                emp.Display();
                            }
                        }  
                        break;

                    case 4 :
                        if (managers.Count==0)
                        {
                            Console.WriteLine("No manager in system");
                        }
                        else
                        {
                            foreach(Manager m in managers)
                            {
                                m.DisplayManager();
                            }
                        }  
                        break;    
                    case 5:
                        Console.Write("Enter employee Id");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        bool found = false;
                        foreach(Employee emp in employees)
                        {
                            if(emp.Id == searchId)
                            {
                                emp.Display();
                                found = true;
                                break;
                            }
                        }if(!found)
                        {
                            Console.WriteLine("Emplyee not found");
                        }
                        break;
                    case 6:
                        return;    
                        
                    default:
                    Console.WriteLine("Invalid Choice");
                    break;
                }
                
            }catch(FormatException)
            {
                Console.WriteLine("Please enter numbers only");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

