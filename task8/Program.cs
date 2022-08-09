// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Multiple(int num, int a, int b)
{
    return num % a == 0 && num % b == 0;
}

if (Multiple(number, 7, 23)) Console.WriteLine($"{number} -> Да");
else Console.WriteLine($"{number} -> Нет");