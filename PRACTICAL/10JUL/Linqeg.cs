//LINQ - language integrated query
//used to query collections like arrays , list
//where : filter data , select(), orderBy(), orderByDesending()
//forst(), count() ,min() , max(), sum()

using System;
using System.Linq;

class Linqeg
{
    static void Main()
    {
        int[] numbers = { 8,7,6,4,3,2,5,9,1};
        var even = numbers.Where(x=>x%2==0);

        foreach(var n in even)
        {
            Console. WriteLine(n);
            
        }
    }
}