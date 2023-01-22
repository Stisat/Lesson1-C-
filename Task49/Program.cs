// Задача 49: Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на их квадраты.

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

int[,] SetSquareArray(int [,] array)
{

    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i += 2)
            array[i, i] *= array[i, i];

    return array;
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


int rows = 7;
int columns = 4;

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine();

SetSquareArray(array);
PrintArray(array);