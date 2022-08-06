//  Задача 1. Написать программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя) 

Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// //int sqrt = number * number;
// //number *= number;
// int sqrt = Convert.ToInt32(Math.Pow(number, 2));
// Console.WriteLine("число в квадрате: " + sqrt);


// Задача 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int sqrt = number2 * number2;
// if(number1 == sqrt)
// {
//     Console.WriteLine("Первое число является квадратом второго числа");
// }
// else
// {
//     Console.WriteLine("Первое число не является квадратом второго числа");
// }


// Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("Input number of the day: ");

int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.WriteLine("Incorrect number");
}
else
{
    if (day == 1)
    {
        Console.WriteLine("Monday");
    }
    if (day == 2)
    {
        Console.WriteLine("Tuesday");
    }
    if (day ==3)
    {
        Console.WriteLine("Wednesday");
    }
    if (day == 4)
    {
        Console.WriteLine("Thursday");
    }
    if (day == 5)
    {
        Console.WriteLine("Friday");
    }
    if (day == 6)
    {
        Console.WriteLine("Saturday");
    }
    if (day == 7)
    {
        Console.WriteLine("Sunday");
    }
}