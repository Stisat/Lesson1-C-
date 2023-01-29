// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int [,] MatrixMultiplication (int [,] arrA, int [,] arrB)
{
    int [,] newArr = new int [arrA.GetLength(0), arrB.GetLength(1)];
    for (int row = 0; row < arrA.GetLength(0); row++)
    {
        for (int column = 0; column < arrB.GetLength(1); column++)
        {
            for (int i = 0; i < arrA.GetLength(1); i++)
            {
                newArr[row,column] += arrA[row,i] * arrB[i,column]; 
            }
        }             
    }
    return newArr;
}


// добавить проверку строк и столбцов массива А и В

Console.Clear();
int row = 3;
int column = 3;
int [,] arrayOne = SetArray(row, column, 0, 10);
int [,] arrayTwo = SetArray(row, column, 0, 10);
int [,] arrMulti = MatrixMultiplication(arrayOne, arrayTwo);
PrintArray(arrayOne);
Console.WriteLine();
PrintArray(arrayTwo);
Console.WriteLine("Результирующая матрица:");
PrintArray(arrMulti);