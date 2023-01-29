// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.


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
int [] GetMinSumRow (int [,] arr)
{
    int sum = 0;
    int [] sumRow = new int[arr.GetLength(1)];
    int minSum = sumRow[0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i,j]; 
        }
        sumRow[i] = sum;
        sum = 0;
    }
    return sumRow;
}
int MinPosition (int [] col)
{
    int min =col[0];
    int rowPosition =0;
    for (int i = 1; i < col.Length-1; i++)
    {
         if (col[i]<min)
        {
            min = col[i];
            rowPosition = i;
        }
    }
    return rowPosition;
}
void PrintMinSumArray(int[,] inArray, int pos)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($" {inArray[pos,j]} ");
        }
    Console.WriteLine();
    Console.WriteLine($"{pos+1} строка");
}


Console.Clear();
int row = 3;
int column = 4;
int [,] array = SetArray(row, column, 0, 10);
PrintArray(array);
Console.WriteLine();
int [] rowMin = GetMinSumRow(array);
int minPos = MinPosition(rowMin);
PrintMinSumArray(array,minPos);
