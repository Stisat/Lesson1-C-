// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int [] BinMass (int size) // Функция задания массива случайных трёхзначных чисел размером size;
{
    int [] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

int NumEvenVal (int [] collect) // Функция нахождения количества четных чисел в массиве;
{
    int size = collect.Length;
    int result = 0;
    for (int i = 0; i < size; i++)
    {
        if (collect[i] %2 == 0)
        {
            result = result + 1;
        }
    }
    return result;
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int count = Convert.ToInt32(Console.ReadLine()); 
int [] array = BinMass(count);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве равно: {NumEvenVal(array)}");
