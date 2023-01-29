// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Сумма цифр числа:"+Sum(num));
int Sum(int inputNum)
{
    if (inputNum < 10) return inputNum;
    else return inputNum % 10 + Sum(inputNum / 10);
}


