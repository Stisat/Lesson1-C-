﻿// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] ChangeRawColumn (int [,] arr)
{
    int [,] newArr = new int [arr.GetLength(1), arr.GetLength(0)];
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            newArr[i,j] = arr[j,i];
        }
    }
    return newArr;
}

int [,] array = GetArray(3,4,0 , 10);
PrintArray(array);
Console.WriteLine();
int [,] newAr = ChangeRawColumn(array);
PrintArray(newAr);