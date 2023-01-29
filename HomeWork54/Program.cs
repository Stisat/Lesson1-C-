// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] SetArray(int row, int column, int minValue, int maxValue)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
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
            Console.Write($" {inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}


int [,] SortRowMaxToMin (int [,] arr)
{
    int maxPosition =0;
    int temp = 0;

    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1)-1; column++)
        {
            maxPosition = column;
            for (int j =column+1; j < arr.GetLength(1); j++)
            {
                if (arr[row,j] > arr[row,maxPosition])
                {
                    maxPosition = j;
                }
            }
        temp = arr[row,column];
        arr[row,column] = arr[row,maxPosition];
        arr[row,maxPosition] = temp;
        }
    }
    return arr;
} 


Console.Clear();
int row = 3;
int column = 4;
int [,] array = SetArray(row, column, 0, 10);
PrintArray(array);
int [,] arrNew =SortRowMaxToMin(array);
Console.WriteLine();
PrintArray(arrNew);
