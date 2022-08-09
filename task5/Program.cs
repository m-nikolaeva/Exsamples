// 9. Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100); // по условию, включительно 10 и 99
Console.WriteLine($"Случайное число из отрезка 10-99 -> {number}");


// int firstDigit = num / 10; //7 из первого примера, 78
// int secondDigit = num % 10; //8

// if (firstDigit == secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} -> цифры одинаковые");
// else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {number} -> {secondDigit}");   

// int res = firstDigit > secondDigit ? firstDigit : secondDigit;    //тернарный оператор, переменная = (условие) ? (возвращаемое значение, если условие истинно) : (возвращаемое значение если условие ложно);
// Console.WriteLine($"Наибольшая цифра числа {number} -> {res}");
// return res;
        
int MaxDigit(int num)
{
    int firstDigit = num / 10; //7 из первого примера, 78
    int secondDigit = num % 10; //8
    if(firstDigit == secondDigit) return -1;
    return firstDigit > secondDigit ? firstDigit : secondDigit; 
}   

int result = MaxDigit(number);
string res = result == -1 ? "Цифры одинаковые" : result.ToString();   
Console.WriteLine($"Наибольшая цифра числа {number} -> {res}");   

