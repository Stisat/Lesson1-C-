// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void OutputNumbers(int n, int m) 
{
    if (n >= m)
    {
        OutputNumbers(n - 1,m);
        Console.WriteLine(n);
    }
}

Console.Write("Введите число: N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: M: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n>m)
{
    OutputNumbers(n, m);
}
if (m>n)
{
    OutputNumbers(m, n);
}
if (n == m)
{
    Console.WriteLine("Нет натуральных чисел");
}