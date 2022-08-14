//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// int num = int.Parse(Console.ReadLine());
// int num_copy = num;
// int last_digit = 0;
// int num_rev = 0;

// if(num < 9999 || num > 99999)
// {
//     Console.WriteLine("Вы ввели не пятизначное число");
// }
// else
// {
//     while(num_copy != 0)
//     {
//         last_digit = num_copy % 10;
//         num_rev = num_rev * 10 + last_digit;
//         num_copy = num_copy / 10;
//     }
//     if(num_rev == num)
//     {
//         Console.WriteLine("Число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Число не является палиндромом");
//     }
// }





// Задача 21: Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние между ними в 3D пространстве.


// Console.Clear();
// Console.Write("Введите X1: ");
// int x1=int.Parse(Console.ReadLine());
// Console.Write("Введите Y1: ");
// int y1=int.Parse(Console.ReadLine());
// Console.Write("Введите Z1: ");
// int z1=int.Parse(Console.ReadLine());
// Console.Write("Введите X2: ");
// int x2=int.Parse(Console.ReadLine());
// Console.Write("Введите Y2: ");
// int y2=int.Parse(Console.ReadLine());
// Console.Write("Введите Z2: ");
// int z2=int.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));

// Console.WriteLine($"d={d:f2}");




// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125


// Console.Clear();
// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine());

// for (int i = 1; i <= N; i++)
// {
//     Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
// }



// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// Console.Clear();
// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine());

// for (int i = 1; i <= N; i++)
// {
//     Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
// }