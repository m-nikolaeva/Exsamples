// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите целое положительное число: ");
long num = Convert.ToInt64(Console.ReadLine());

long GetFact(long number)
{
    long fact = 1;
    for (long i = 1; i <= number; i++)
    {
        fact*=i; //fact = fact*i
    }
    return fact;
}

long res = GetFact(num);
Console.WriteLine($"Произведение чисел от 1 до{num} -> {res}");
