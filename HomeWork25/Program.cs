// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
numberA = Math.Abs(numberA); // исключение отрицательного ввода числа А;
Console.WriteLine("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());
numberB = Math.Abs(numberB); // исключение отрицательного ввода числа В;
int result = 1;

for (int i = 0; i < numberB; i++)
{
    result = result * numberA;
}

Console.WriteLine($"Число {numberA} в степени {numberB} равняется {result}");

