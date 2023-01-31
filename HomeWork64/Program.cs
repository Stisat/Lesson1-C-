//Задача 64: Задайте значение N. Напишите программу,
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


void OutputNumbers(int n) 
{
    if (n >= 1)
    {
        OutputNumbers(n - 1);
        Console.WriteLine(n);
    }
}

Console.Write("Введите натуральное положительное число: N: ");
int n = Convert.ToInt32(Console.ReadLine());
OutputNumbers(n);
