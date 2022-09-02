// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.Write("Введите целое положительное чиcло M -> ");
int m0 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое положительное чиcло N-> ");
int n0 = Convert.ToInt32(Console.ReadLine());

void PrintNaturalis(int m, int n)
{
    Console.Write($"{m} ");
    if (m > n)
        PrintNaturalis(m - 1, n);
    else if (m < n)
        PrintNaturalis(m + 1, n);
    
}

PrintNaturalis(m0, n0);
Console.WriteLine();