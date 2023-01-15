// Задача №38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] DoubleMass (int size) // Функция задания массива случайных вещественных чисел от -100 до 100 размером size;
{
    double [] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Convert.ToDouble(new Random().Next(-1000, 1000)/10.0);
    }
    return result;
}

void SumMaxMin(double [] col) // Метод определения Max, Min и нахождения разницы между ними;
{
    double result = 0;
    double Min = col[0];
    double Max = col[0];
    int size = col.Length;
    for (int i = 1; i < size; i++)
    {
        if (col[i] < Min) Min = col[i];
        if (col[i] > Max) Max = col[i];
    }
    result = Max - Min;
    Console.WriteLine();
    Console.WriteLine($"Максимальное число массива: {Max}");
    Console.WriteLine($"Минимальное число массива: {Min}");
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {result:f3}.");   
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int sizeAr = Convert.ToInt32(Console.ReadLine()); 
double [] array = DoubleMass(sizeAr);
Console.WriteLine($"[ {String.Join(", ", array)} ] ");
Console.WriteLine();
SumMaxMin(array);