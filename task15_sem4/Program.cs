// Задача 26: Напишите программу, которая
// 1. принимает на вход число и 
// 2. выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int NumCount(int number)
{
    int sum = 0;
    for (int i = 1; number > 0; i++)
    {
        number = number / 10;
        sum = i;
    }
    return sum;
}

int res = NumCount(num);
Console.WriteLine($"Количество цифр в числе {num} = {res}");