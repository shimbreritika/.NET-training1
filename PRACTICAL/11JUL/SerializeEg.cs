//seialization - converts an object into a form(JSON) do it can be saved and sharp

using System;
using System.Text.Json;

class SerializeEg
{
    static void Main()
    {
        Employee e = new Employee(101,"xyz",4500);

    
        string json = JsonSerializer.Serialize(e);
        Console.WriteLine(json);

        //{101,xya, 4500}

        //deseialize
        Employee e1 = JsonSerializer.Deserialize<Employee>(json);
        Console.WriteLine(e1.EmpName);
    }

}