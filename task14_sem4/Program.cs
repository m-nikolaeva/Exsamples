// Задача 24: Напишите программу, которая
// 1. принимает на вход число (А) и 
// 2.выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// for (int i = 1; i <= num; i++)
// {
//    sum +=i;  //sum = sum + i;
// }

// Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");


// Метод:

int SumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum +=i;  //sum = sum + i;
    } 
    return sum;
}

int result = SumNumbers(num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {result}");