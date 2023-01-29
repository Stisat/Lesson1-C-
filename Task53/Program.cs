// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

void ChangeRow(int [,] array){

  int temp = 0;

  for(int i=0; i < array.GetLength(0); i++){
    temp = array[0, i];
    array[0, i] = array[array.GetLength(0)-1, i];
    array[array.GetLength(0)-1, i] = temp;
  }

}


int [, ] array = GetArray(3, 4, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();

ChangeRow(array);
PrintArray(array);