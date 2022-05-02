Console.WriteLine("Введите число 1 ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2 ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 3 ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (a > b) 
     if(a > c)
    max = a;


if (b > a) 
     if(b > c)
    max = b;

if (c > a) 
     if(c > b)
    max = c;

Console.WriteLine(max);