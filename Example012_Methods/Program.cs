//Вид 1: ничего не возвращает, ничего не принимает.
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// Method1(); //вызов метода, НЕ ЗАБЫВАЕМ ()!!!



//Вид 2:ничего не возвращает, но может принимать аргументы.
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения"); //вызов метода

// void Method21(string msg, int count)  //вариант с несколькими аргументами
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Текст", 4); //или Method21(msg: "Текст", count: 4)


//Вид 3: что-то возвращают, но ничего не принимают
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3(); // вызов метода
// Console.WriteLine(year);



//Вид 4: что-то принимают, что-то возвращают
// string Method4(int count, string text) //строка text будет компоноваться друг за другом count раз
// {
//     int i=0;
//     string result = String.Empty; //место куда будет падать результат = пустая строка

//     while (i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }


// string Method4(int count, string text) //строка text будет компоноваться друг за другом count раз
// {
//     string result = String.Empty; //место куда будет падать результат = пустая строка

//     for (int i = 0; i < count; i++) //в скобках: инициализация счетчика; проверка условия; инкремент==увеличение счетчика
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);

//Таблица умножения - цикл в цикле

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие "к" заменить большими "К", 
// большие "С" заменить маленькими "с".

//Ясна ли задача??

// string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// //string s = "qwerty" - в строке есть вспомогательный функционал
// //            0123    - чтобы обратиться к конкретному символу строки, необходимо посчитать позицию необходимого символа, как в массиве
// // s[3] // r   -через идентификатор строки 

// string Replace(string text, char oldValue, char newValue)
// {
//     string result=String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'с', 'С');
// Console.WriteLine(newText);
// Console.WriteLine();

//====Задача от минимального к максимальному
//1.Найти позицию минимального элемента в неотсортированной части массива
//2.Произвести обмен этого значения со значением первой неотсортированной позиции
//3. Повторять, пока есть неотсортированные элементы

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)   //этот блок кода ищет только максимальный элемент
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }

//         int temporary = array[i];
//         array[i] = array[minPosition]; //обмен позиций местами
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);

//====Задача от максимального к минимальному

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)   //этот блок кода ищет только максимальный элемент
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition]; //обмен позиций местами
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);