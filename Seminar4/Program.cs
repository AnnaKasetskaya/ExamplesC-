// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


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
// Console.WriteLine($"Cумма цифр от 1 до введенного числа: {GetSumNums(num)}");

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int GetCountDigit(int number)
{
    int count = 0;
    if(number == 0) count = 1;
    else
    {
        while(Math.Abs(number) > 0)
        {
            number = number / 10;
            count++;
        }
    }
    return count;
}

// Console.WriteLine("Ввведите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Количество цифр в числе: {GetCountDigit(num)}");




// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int GetCompNums(int number)
// {
//     int comp = 1;
//     for (int i = 1; i <= Math.Abs(number); i++)
//     {
//         comp *= i;
//     } 
//     return comp;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// if(num > 0)
// {
//     Console.WriteLine($"произведение цифр от 1 до введенного числа: {GetCompNums(num)}");
// }
// else
// {
//     Console.WriteLine("Введите положительное число больше нуля");
// }

// Вариант с рекурсией

// long fact(long num)
// {

//     if (num == 1)
//     {
//         return num;
//     }
//     else
//     {
//         return num * fact(num - 1);
//     }
// }

// Console.WriteLine("Введите число N");
// long inputNumber = Convert.ToInt64(Console.ReadLine());
// Console.WriteLine("Факториал числа " + fact(inputNumber));


// Найти произведение цифр в числе.


// int GetCompositionDigit(int number)
// {
//     int comp = 1;
//     while(number > 0)
//     {
//         comp = comp * (number % 10);
//         number = number / 10;
//     }
//     return comp;
// }

// Console.WriteLine("Ввведите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Произведение цифр в числе: {GetCompositionDigit(num)}");



// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] array = new int[8];
// Console.Write("[");
// for (int i = 0; i < array.Length - 1; i++)
// {
//     array[i] = new Random().Next(0,2);
//     Console.Write($"{array[i]}, ");
// }
// Console.Write($"{array[array.Length - 1]}]");
// Console.WriteLine();

