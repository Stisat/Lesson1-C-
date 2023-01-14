// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
numberA = Math.Abs(numberA); // исключение отрицательного ввода числа А;
Console.WriteLine("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());
numberB = Math.Abs(numberB); // исключение отрицательного ввода числа В;
int result = 1;
if ((numberA > 0) && (numberB > 0))
{
    for (int i = 0; i < numberB; i++)
    {
        result = result * numberA;
    }

    Console.WriteLine($"Число {numberA} в степени {numberB} равняется {result}");
}
if ((numberA > 0) && (numberB == 0)) // Любое число возведенное в 0 степень даёт 1;
{
    result = 1;
    Console.WriteLine($"Число {numberA} в степени {numberB} равняется {result}");
}
if (numberA == 0)
{
    Console.WriteLine("Возведение 0 в степень не допускается"); // много споров о возведении 0 в степень. Принимаю так.
}
