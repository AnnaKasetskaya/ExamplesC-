// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }


// int[] CreateArray()
// {
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     { 
//         Console.WriteLine($"Введите {i+1} элемент массива");
//         RandomArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return RandomArray;
// }


// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Clear();
// Console.WriteLine("Введите количество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число случайно генерируемого диапазона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myRandomArray = CreateRandomArray(num, min, max);
// ShowArray(myRandomArray);
// Console.WriteLine("-------");
// int[] myArray = CreateArray();
// ShowArray(myArray);




// int[] GetRandomArray(int size,int minValue,int maxValue)
// {
// int[] result = new int[size];
// for (int i = 0; i < size; i++)
// {
// result[i] = new Random().Next(minValue,maxValue);
// }

// return result;
// }


// Console.Clear();
// int[] array = GetRandomArray(8,0,100);
// Console.WriteLine($"[{String.Join(", ", array)}]");




// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.


int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int sum_pos = 0;
// int sum_neg = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0)
//         sum_pos += myArray[i];
//     else
//         sum_neg += myArray[i];
// }

// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие
//  отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// for (int i = 0; i < myArray.Length; i++)
// {
//     myArray[i] *= -1;
// }

// Console.WriteLine("Новый массив: ");
// ShowArray(myArray);




// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);
// Console.WriteLine("Какое число ищем в массиве? ");

// int num = int.Parse(Console.ReadLine());
// int i = 0;
// int count = 0;

// while(i < myArray.Length)
// {
//     if(myArray[i] == num)
//     {
//         Console.WriteLine("Число есть в массиве.");
//         count++;
//         break;
//     }
//     i++;
// }

// if(count == 0) Console.WriteLine("Числа нет в массиве.");


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// int[] myArray = CreateRandomArray(123, -100, 100);
// ShowArray(myArray);
// int count = 0;

// for(int i=0; i < myArray.Length; i++)
// {
//     if(myArray[i] >= 10 &&myArray[i] <= 99) count++;
// }
// Console.WriteLine(count);

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний
//  элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();
Console.WriteLine("Введите количество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайно генерируемого диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(num, min, max);
ShowArray(myArray);


if(myArray.Length % 2 == 0)
{
    int[] newMyArray = new int[myArray.Length / 2];
    for (int i = 0; i < myArray.Length / 2; i++)
    {
        newMyArray[i] = myArray[i] * myArray[myArray.Length - 1 - i];
    }
    ShowArray(newMyArray);
}
else
{
    int[] newMyArray = new int[myArray.Length / 2 + 1];
    for (int i = 0; i < myArray.Length / 2; i++)
    {
        newMyArray[i] = myArray[i] * myArray[myArray.Length - 1 - i];
    }
    newMyArray[myArray.Length / 2] = myArray[myArray.Length / 2];
    ShowArray(newMyArray);
}
