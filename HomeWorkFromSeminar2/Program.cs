﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.


// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num >= 100 && num < 1000)
// {
//     Console.WriteLine(num / 10 - num / 100 * 10);
// }
// else 
// {
//     Console.WriteLine("Вы ввели нетрехзначное число");
// }



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(num > -100 && num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while(Math.Abs(num) > 1000)
    {
        num = num / 10;
    }
    Console.WriteLine(Math.Abs(num) % 10);
}



// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.


// Console.Write("Введите цифру от 1 до 7, соответствующую дню недели от понедельника до воскресенья ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1 || day > 7)
// {
//     Console.WriteLine("Вы ввели неправильную цифру");
// }
// else
// {
//     if (day == 6 || day == 7)
//     {
//         Console.WriteLine("Это выходной день");
//     }
//     else
//     {
//         Console.WriteLine("Это рабочий день");
//     }
// }