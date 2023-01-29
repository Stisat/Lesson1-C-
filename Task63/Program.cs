// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.


void OutputNumbers(int n) 
{
    if (n >= 1) {
        OutputNumbers(n - 1);
        Console.WriteLine(n);
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

OutputNumbers(n);