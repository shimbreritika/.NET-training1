using System;
using System.Runtime;

class OOP
{
    static void Main()
    {
        Empolyee e = new Empolyee();

        e.EmpName = "Ritika";
        e.Salary = 1076;

        Console.WriteLine(e.EmpName + " " + e.Salary);

        ComplietimePoly c = new ComplietimePoly();
        c.Search(100);
        c.Search(234567891);
        c.Search("Ritika", "Boga");

        RuntimePoly r = new RuntimePoly();
        r.checkout(new UpiPayment(), 500);
        r.checkout(new CreditPayment(), 55000);
        r.checkout(new NetBanking(), 25000);

        FileStorage s = new abstracteg();
        s.Upload("CV.pdf");
        s.validateFile();
    }
}