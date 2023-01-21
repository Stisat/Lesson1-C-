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
// void RanArray(int [] collection)
// {
//     int size = collection.Length;
//     int index = 0;
//     while (index < size)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write($"{col[position]}. ");
//         position++;
//     }
// }

// int Max(int [] mass)
// {
//     int size = mass.Length;
//     int index = 0;
//     int max = mass[1];
//     while (index<size)
//     {
//         if (mass[index] > max)
//         {
//             max = mass[index];
//         }
//         index++;
//     }
//     return max;
// }

// int [] array = new int[10]; // задание пустого массива на 10 элементов;
// RanArray(array);
// PrintArray(array);

// int Maximum = Max(array);


// Console.WriteLine();
// Console.WriteLine(Maximum);

// for (int i = 2; i <=10; i++)
// {
//     for (int j = 2; j <=10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// Двумерные массивы

// string[,]table = new string[2,5];
//string.empty
// table [0,0]  table [0,1]   table [0,2]... table [0,4]
// table [1,0]  table [1,1]   table [1,2]... table [1,4]
// table[1, 2] = "word";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns< 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-")
//     }
// }

// int[,] matrix = new int[3, 4];

// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j< 4; j++)
//     {
//         Console.Write($"-{matrix[i, j]}-");
//     }
// }
// Console.WriteLine();

//факториал через рекурсию

// int Factorial (int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n-1);
// }

// Console.WriteLine(Factorial(3));

// число фибоначчи
// f(1)=1
// f(2)=1
// f(n)=f(n-1)+f(n-2)

double Fibo(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibo(n-1) + Fibo(n-2);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine(Fibo(i));
}

