// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

//Array.Reverse(arr);


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

// void ReverseArray(int[] array)   //разворот массива с while
// {
//     int size = array.Length;
//     int index1 = 0;
//     int index2 = size - 1;

//     while(index1<index2)
//     {
//         int obj = array[index1];
//         array[index1] = array[index2];
//         array[index2] = obj;

//         index1++;
//         index2--;
//     }
// }


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}


// int[] arr = CreateArrayRndInt(5, 5, 9);
// PrintArray(arr);
// ReverseArray(arr);
// PrintArray(arr);



void ReverseArray1(int[] array)   //разворот массива с for
{
    int size = array.Length;

    for (int i = 0; i < size / 2; i++)
    {
        int temp = array[i];
        array[i] = array[size - 1 - i];
        array[size - 1 - i] = temp;
    }

}

int[] arr = CreateArrayRndInt(5, 5, 9);
PrintArray(arr);
ReverseArray1(arr);
PrintArray(arr);
