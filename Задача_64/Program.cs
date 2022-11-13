// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Ведите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int m = 1;
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
