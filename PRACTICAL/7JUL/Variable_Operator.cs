//datatype varaiblename = value;
//-------- value type
//numeric = int 4, long 8
//decimal = float 4, double 8, decimal 16
//char 2
//bool 1
//-------- reference type these stores refernces(memory address) of the data
//string, object, class, array, interface

int age= 75;
long pnumber= 10000000000;
double pi= 10.5;
bool pass=true;
Console.WriteLine(age);
Console.WriteLine(pnumber);
Console.WriteLine(pi);
Console.WriteLine(pass);

//operators
//arithmatic --- + - / * %
//assignment --- = += -= *= /= 
int x=10; x*=5;
//comparison --- == != > < >= <=
int x1=9; int y=59;
Console.WriteLine(x1>y);
Console.WriteLine(x1==y);

//Logical --- && || !
bool a=true; bool b=false;
Console.WriteLine(a && b);
Console.WriteLine(a || b);
Console.WriteLine((a && b) || (x1>y));

//Increment/Decrement --- ++ --
int i=10;
int z=20;
z++; z++; --z; z--;
Console.WriteLine(z);