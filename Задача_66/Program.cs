// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

int z = n;
if(m > n)
{
    z = n;
    n = m; 
    m = z;
}

void PrintN(int m, int n)
{
    if (m <= n)
    {
        Console.Write($"{n} ");
        PrintN(m, n-1);
    }
}
PrintN(m, n);
Console.WriteLine();

int sum = 0;
void SumMN(int m, int n)
{
    if(m <= n)
    {
        sum = sum + n;
        SumMN(m, n-1);
    }
}
SumMN(m, n);
Console.Write($"Сумма чисел: {sum} !!");
Console.WriteLine();


