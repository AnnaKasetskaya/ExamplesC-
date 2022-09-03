// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillDoubleArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(new Random().Next(-100,100)/10.0);
        }
    }
}


void PrintDoubleArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j] }   ");
        }
        Console.WriteLine();
    }
}

// Console.WriteLine("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] arrToDouble = new double[m, n];
// FillDoubleArray(arrToDouble);
// PrintDoubleArray(arrToDouble);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Вариант 1 (находим элемент по позиции)

void FindElement(int inStr, int inCol, int[,] matr)
{
    if(((inStr - 1) <= matr.GetLength(0)) 
    && ((inCol - 1) <= matr.GetLength(1))) // с поправкой на то, что пользователь нумерует 
                                           //строки и столбцы с 1, а не с 0
    {
    Console.WriteLine($"{matr[inStr - 1, inCol - 1]} ");
    }
    else Console.WriteLine("Такого элемента нет в массиве");
}

// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// PrintArray(matrix);

// Console.WriteLine("Введите номер строки: ");
// int str = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца: ");
// int col = Convert.ToInt32(Console.ReadLine());
// FindElement(str, col, matrix);

//Вариант 2 (находим элемент по значению)

string FindElement1(int element, int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i, j] == element)
            {
                return ($"Элемент {element} на позиции {i + 1}, {j + 1}");
            }
        }
    }
    return ("Такого элемента нет в массиве");
}

// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// PrintArray(matrix);

// Console.WriteLine("Введите число, которое нужно найти в матрице: ");
// int elem = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindElement1(elem, matrix));


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
//  в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FindAverage (int[,] matr)
{
    double sum = 0;
    double[] average = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i,j];
        }
        average[j] = sum / matr.GetLength(0);
        Console.Write("{0,5:F2}", average[j]);
        sum = 0;
    }
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
FindAverage(matrix);