// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number); // исключение отрицательного ввода числа для определения длины строки;
string str = Convert.ToString(number);
int size = str.Length;
int sum = 0;
int tempvar = 0;
int printnum = number;
while (size > 0 )
    {
        size = size - 1;
        tempvar = number %10;
        number = number / 10;
        sum = sum + tempvar;
    }

Console.WriteLine();
Console.WriteLine($"Сумма цифр числа {printnum} равна {sum}");