Console.WriteLine("Введите положительное число ");

int N = int.Parse(Console.ReadLine());
int Y = 2;

while (Y <= N)
{
    Console.Write(Y + ",");
    Y = Y + 2;
}

if (N <= 1) 
{
    Console.WriteLine("Четных чисел нет ");
}