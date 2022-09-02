// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите целое положительное число: ");
int m = Convert.ToInt32(Console.ReadLine());
int sum = DigitsSum(m);

Console.WriteLine($"Сумма цифр = {sum}");

int DigitsSum(int number)
{
	if (number < 10)
		return number;
	return number % 10 + DigitsSum(number / 10);
}