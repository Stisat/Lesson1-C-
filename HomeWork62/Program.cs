//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:


int [,] SetArray(int row, int column)
{
    int[,] result = new int[row, column];
    int k = 1;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++, k++)
        {
            result[i, j] = k;
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
            Console.Write(inArray[i,j]+ "\t");
        }
        Console.WriteLine();
    }
}

int [] TwoDimToOneDim (int [,] twoDim)
{
    int [] oneDim = new int [16];
    int k = 0;
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
        oneDim[k] = twoDim[i, j];
        k++;
        }
    }
    return oneDim;
}

int [,] SpiralSort (int [] arrayOneDim)
{
    int [,] twoDimArr = new int[4,4];
    int n = 0;
    for (int row = 0; row < 4; row++)
    {
        for (int j = row; j < 4 - row; j++)
        {
            twoDimArr[row, j] = arrayOneDim[n++];
        }
        for (int l = row + 1; l < 4 - row; l++)
        {
            twoDimArr[l, 4 - 1 - row] = arrayOneDim[n++];
        }
        for (int j = 4 - row - 2; j >= row; j--)
        {
            twoDimArr[4 - 1 - row, j] = arrayOneDim[n++];
        }
        for (int l = 4 - 2 - row; l > row; l--)
        {
            twoDimArr[l, row] = arrayOneDim[n++];
        }
    }
    return twoDimArr;
}
Console.Clear();
int[,] arrayTwoDim = SetArray(4,4);

int[] arrayOneDim = TwoDimToOneDim(arrayTwoDim);
arrayTwoDim = SpiralSort(arrayOneDim);

Console.WriteLine();
PrintArray(arrayTwoDim);