// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string GetRange( int qur)
{
    if (qur == 1) return "Диапазон координат точек x > 0, y > 0";
    if (qur == 2) return "Диапазон координат точекx < 0, y > 0";
    if (qur == 3) return "Диапазон координат точек x < 0, y < 0";
    if (qur == 4) return "Диапазон координат точек x > 0, y < 0";
    return "Некорректный номер четверти";
}

string result = GetRange(quarter);
Console.WriteLine(result);