// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число -> {number}");

int firstDigit = number / 100; //получили первую цифру
int secondDigit = number % 10; //получили последнюю цифру

int result = firstDigit * 10 + secondDigit;
Console.WriteLine($"Преобразованное число -> {result}");
