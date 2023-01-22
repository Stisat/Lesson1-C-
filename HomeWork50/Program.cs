// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void FindValueByNumber (int [,] arr, int num)
{
    int index = 0;
    int size = arr.GetLength(0) * arr.GetLength(1);
    int [] tempArr = new int[size];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tempArr[index] = arr[i,j];
            index++;
        }
    }
    if (num < size)
    {
        for (int k = 0; k < size; k++)
        {
            if (num-1 == k)
            {
                Console.WriteLine($"На позиции {num} находится число: {tempArr[k]}");
                break;
            }  
        }
    }
    else Console.WriteLine("Такого числа в массиве нет");
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

int row = 3;
int column = 4;
int [,] Array = SetArray(row, column, 0, 10);
PrintArray(Array);
Console.WriteLine();
Console.Write("Введите позицию числа (по порядку 1, 2, 3 и т.д.) массива выше: ");
int NumPosition = Convert.ToInt32(Console.ReadLine());
FindValueByNumber(Array, NumPosition);
