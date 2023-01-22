// 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
// Aₘₙ = m+n. Выведите полученный массив на экран

int rows = 3;        
int columns = 4;

int[,] array = SetArray(rows, columns);
PrintArray(array);

int[,] SetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            result[i, j] = i + j;
        
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

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

