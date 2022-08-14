// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


// void PrintQuarter(int x, int y)
// {
//     if(x > 0 && y > 0)
//     {
//         Console.WriteLine("Точка находится в первой плоскости");
//     }
//     else if(x < 0 && y > 0)
//     {
//         Console.WriteLine("Точка находится во второй плоскости");
//     }
//     else if(x < 0 && y < 0)
//     {
//         Console.WriteLine("Точка находится во третьей плоскости");
//     }
//     else if(x > 0 && y < 0)
//     {
//         Console.WriteLine("Точка находится во четвертой плоскости");
//     }
//     else Console.WriteLine("Плоскость не определена");

// }

// Console.WriteLine("Введите координату x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y");
// int y = Convert.ToInt32(Console.ReadLine());

// PrintQuarter(x, y);


// Второй спрособ:

// Console.Write("Введите координаты точки X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координаты точки Y: ");
// int y = int.Parse(Console.ReadLine()!);
// string mes = "";

// switch (x, y)
// {
// case (>0, >0): mes = "1"; break;
// case (>0, <0): mes = "4"; break;
// case (<0, >0): mes = "2"; break;
// case (<0, <0): mes = "3"; break;
// default : mes = "введите отличное от 0"; break;
// }
// Console.WriteLine(mes);




// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).


// Console.Write("Введите номер четверти: ");
// int quarter=int.Parse(Console.ReadLine());

// switch (quarter)
// {
//     case 1:
//     {
//         Console.WriteLine("x>0 y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("x<0 y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("x<0 y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("x>0 y<0");
//         break;
//     }

//     default:
//     {
//         Console.WriteLine("Введена неправильная четверть");
//         break;
//     }
// }




// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// Console.Clear();
// Console.Write("Введите X1: ");
// int x1=int.Parse(Console.ReadLine());
// Console.Write("Введите Y1: ");
// int y1=int.Parse(Console.ReadLine());
// Console.Write("Введите X2: ");
// int x2=int.Parse(Console.ReadLine());
// Console.Write("Введите Y2: ");
// int y2=int.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));

// Console.WriteLine($"d={d:f2}");

