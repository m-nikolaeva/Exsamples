// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Console.WriteLine("Введите трехзначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Последняя цифра числа {a}={a%10}");

// int a;
// do
// {
// Console.WriteLine("Введите трехзначное число: ");
// a = Convert.ToInt32(Console.ReadLine());
// }
// while (a <= 99 || a > 999);
// Console.WriteLine($"Последняя цифра числа {a}={a%10}");

Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 100 && a < 1000)
{
    Console.WriteLine($"Последняя цифра числа {a}={a%10}");
}
else
Console.WriteLine("Вы ввели не трехзначное число. Повторите попытку");