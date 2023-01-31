// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

int OutputNumbers(int n, int m) 
{
    if (n >= m)
    {
        return (n = n + OutputNumbers(n - 1,m));
    }
    else 
    {
        return 0;
    }
}
Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N, больше M: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр в диапазоне от {m} до {n} равна: {OutputNumbers(n,m)}");
