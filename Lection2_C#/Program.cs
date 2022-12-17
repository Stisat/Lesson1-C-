// Лекция о применении функций и циклов в языке C#;
// Классический подход;
// int a1 = 2;
// int b1 = 3;
// int c1 = 12;
// int a2 = 23;
// int b2 = 22;
// int c2 = 33;
// int a3 = 13;
// int b3 = 55;
// int c3 = 1;

// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1; 

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

// Console.WriteLine(max);

// Написание программы через функцию;


// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2>result) result = arg2;
//     if (arg3>result) result = arg3;
//     return result;   
// }

// int a1 = 2;
// int b1 = 3;
// int c1 = 12;
// int a2 = 23;
// int b2 = 22;
// int c2 = 33;
// int a3 = 13;
// int b3 = 55;
// int c3 = 1;
// //Можно написать вывод программы вот так:
// // int max1 = Max(a1, b1, c1);
// // int max2 = Max(a2, b2, c2);
// // int max3 = Max(a3, b3, c3);
// // int max = Max(max1, max2, max3);

// // Можно вот так:
// int max = Max(
//     Max(a1, b1, c1),
//     Max(a2, b2, c2),
//     Max(a3, b3, c3));
// Console.WriteLine(max);

// Таже программа через массив array:
// Массив задаем через RANDOM;
void RanArray(int [] collection)
{
    int size = collection.Length;
    int index = 0;
    while (index < size)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}. ");
        position++;
    }
}
int [] array = new int[10]; // задание пустого массива на 10 элементов;
RanArray(array);
PrintArray(array);
int size = array.Length;
int index = 0;
int max = array[1];
while (index<size)
{
    if (array[index] > max)
    {
    max = array[index];
    }
    index++;    
}
Console.WriteLine();
Console.WriteLine(max);