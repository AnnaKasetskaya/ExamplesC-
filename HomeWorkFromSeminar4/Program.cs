// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"Число A = {A} в степени B = {B}: {A}^{B} = {Math.Pow(A,B)}");




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSumNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= Math.Abs(number); i++)
    {
        sum += i;
    } 
    return sum;
} 
    

// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"сумма цифр числа: {GetSumNums(num)}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] array = new int[8];
// Console.Write("[");
// for (int i = 0; i < array.Length - 1; i++)
// {
//     array[i] = new Random().Next(0,100);
//     Console.Write($"{array[i]}, ");
// }
// Console.Write($"{array[array.Length - 1]}]");
// Console.WriteLine();