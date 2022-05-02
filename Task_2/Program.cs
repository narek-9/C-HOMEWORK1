Console.WriteLine("Введите число 1 ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2 ");
int b = int.Parse(Console.ReadLine());

int max = a;

if (a > b) max = a; 
else max = b;

Console.Write("max = ");
Console.WriteLine(max);