// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintQuart (int a)
{   
    for (int i = 1; i <= a; i++) // Перебираем от 1 до a
    Console.WriteLine($"{i} \t {i*i}");
}

if (n < 1) 
{
    Console.WriteLine("Введите число > 1");
    return;
}
    PrintQuart (n);



