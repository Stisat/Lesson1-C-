//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

int [,,] SetArray(int [] sizes, int minValue, int maxValue)
{
    int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k = 0;
            while(k<result.GetLength(2))
            {
            int element=new Random().Next(minValue, maxValue+1);
            if(FindElement(result,element)) continue;
            result[i, j, k] = element;
            k++;
            }
        }
    }
    return result;
}

bool FindElement (int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i,j,k]==el) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {   
            for (int k = 0; k< inArray.GetLength(2); k++)
            {
                Console.Write($" {inArray[i,j,k]} ({i},{j},{k}) ");    
            }
            Console.WriteLine();
        }
    
    }
}
int [] sizes = new int[3] {2,2,2};
int minVal = 0;
int maxVal =99;
int [,,] tripleArr = SetArray(sizes,minVal,maxVal);
Console.WriteLine();
PrintArray(tripleArr);