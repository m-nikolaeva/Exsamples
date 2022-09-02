// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введите целое положительное чиcло -> ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int num)
{
    if(num==0) return;
    NaturalNumber(num-1);  //начинаем с N 5 4 3 2 1
    Console.Write($"{num} "); //выводит в обратном порядке 1 2 3 4 5 
}

NaturalNumber(number);