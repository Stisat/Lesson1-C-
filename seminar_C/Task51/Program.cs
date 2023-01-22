// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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

int SumMainDiagArray(int [,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, i];

    return sum;
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


int rows = 4;
int columns = 4;

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"Сумма на главной диагонали {SumMainDiagArray(array)}");