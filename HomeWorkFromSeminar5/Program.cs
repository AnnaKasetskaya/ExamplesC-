// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void FillAndPrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
}

int NumberOfEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

// int[] arr = new int[10];
// Console.WriteLine("Весь массив: ");
// FillAndPrintArray(arr);
// Console.WriteLine();
// Console.WriteLine($"Количество четных чисел в массиве: {NumberOfEvenNumbers(arr)}");




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SumOfElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) sum = sum + array[i];
    }
    return sum;
}

// Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях.: {SumOfElements(arr)}");




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

double[] arrToDouble = new double[10];

for (int i = 0; i < arrToDouble.Length; i++)
{
    arrToDouble[i] = Convert.ToDouble(new Random().Next(100)/10.0);
    Console.Write($"{arrToDouble[i]} ");
}

double max = arrToDouble[0];
double min = arrToDouble[0];

for (int i = 0; i < arrToDouble.Length; i++)
{
    if (arrToDouble[i] > max) max = arrToDouble[i];
    if (arrToDouble[i] < min) min = arrToDouble[i];
}

Console.WriteLine();
Console.WriteLine($"Минимальный элемент массива: {min}, максимальный элемент массива: {max}, их разность: {max - min} ");
