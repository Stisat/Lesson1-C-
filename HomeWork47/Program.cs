// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] SetRealArray(int row, int column, int minValue, int maxValue)
{
    int RandomVal = 0;
    double[,] result = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            RandomVal = new Random().Next(minValue, maxValue);
            result[i, j] = new Random().NextDouble()*RandomVal;
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($" {inArray[i,j]:f2} ");
        }
        Console.WriteLine();
    }
}

int row = 4;
int column = 4;

double [,] array =  SetRealArray(row, column, -100, 100);
PrintArray(array);