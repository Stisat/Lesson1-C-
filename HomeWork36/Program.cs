// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] BinMass (int size) // Функция задания массива случайных чисел от 0 до 9999 размером size;
{
    int [] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 10000);
    }
    return result;
}

void SumOddInd (int [] collect) // Метод нахождения суммы чисел на нечетных позициях массива;
{
    int size = collect.Length;
    int result = 0;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if ((i+1) %2 != 0)
        {
            result = result + collect[i];
            count = count + 1;
            Console.WriteLine($"Число на нечетной позиции {i+1}) {collect[i]}.");
        }
    }
    Console.WriteLine($"Количество нечетных позиций в массиве: {count}");
    Console.WriteLine($"Сумма чисел на нечетных позициях массива равна: {result}");
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int sizeAr = Convert.ToInt32(Console.ReadLine()); 
int [] array = BinMass(sizeAr);
Console.WriteLine($"[ {String.Join(", ", array)} ] ");
Console.WriteLine();
SumOddInd(array);