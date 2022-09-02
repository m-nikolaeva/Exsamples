// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите целое положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целую положительную степень: ");
int b = Convert.ToInt32(Console.ReadLine());

int pow = GetPower(a, b);

Console.WriteLine($"Число {a} в степени {b} равно {pow}");

int GetPower(int number, int p)
{
    if (p == 0)
        return 1;
    // if (p == 1)    //без этого условия работает
    // return number;

    return number * GetPower(number, p - 1);
}