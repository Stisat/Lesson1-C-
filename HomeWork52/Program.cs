// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

void GetAveSumColumn (int [,] arr)
{
    double Sum = 0;
    double AvgSum =0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            Sum += arr[j,i]; 
        }
        AvgSum = Sum/arr.GetLength(0);
        Console.WriteLine($"Среднее арифметическое столбца {i} равняется: {AvgSum:f2}");
        Sum = 0;
    }
}
Console.Clear();
int row = 3;
int column = 4;
int [,] array = SetArray(row, column, 0, 10);
PrintArray(array);
Console.WriteLine();
GetAveSumColumn(array);