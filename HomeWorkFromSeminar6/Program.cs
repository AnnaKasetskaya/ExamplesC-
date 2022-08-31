// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] InputNumbers()
{
    Console.WriteLine("Введите количество чисел: ");
    int M = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    { 
        Console.WriteLine($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}

// Console.WriteLine($"Количество элементов больше 0: {CountNumbers(InputNumbers())}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void GetIntersectionPoint (double k1, double b1, double k2, double b2)
{
    if(k1 == k2) Console.WriteLine("Прямые не пересекаются.");
    else
    {
        double x = (b2 - b1)/(k1 - k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Координаты точки пересечения: x = {x}, y = {y}");
    }
}

// Console.WriteLine("Введите коэффициент первого уравнения прямой k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите коэффициент первого уравнения прямой b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите коэффициент второго уравнения прямой k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите коэффициент второго уравнения прямой b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// GetIntersectionPoint(k1, b1, k2, b2);


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


int GetArrayLength(int copyN)
{
    int length = 0;
    while(copyN > 0)
    {
        copyN = copyN / 2;
        length++;
    }
    return length;
}


void GetBinaryNumber(int length, int N)
{
    int[] array = new int[length];
    int i = 0;
    while (N > 0)
    {
        if (N % 2 == 0) array[i] = 0;
        else array[i] = 1;
        N = N / 2;
        i++;
    }
    ReversArray(array);
}


void ReversArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
        Console.Write(result[i]);
    }
}

// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// GetBinaryNumber(GetArrayLength(N), N);


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] Fibbonacci(int N)
{
    int[] array = new int[N];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < N; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
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

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
ShowArray(Fibbonacci(N));
