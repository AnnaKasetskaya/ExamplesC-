﻿int[] array = {1, 4, 56, 76, 87, 999, 4, 555, 65};

int n = array.Length;
int find = 4;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
