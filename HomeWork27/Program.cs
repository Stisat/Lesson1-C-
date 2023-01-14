// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number); // исключение отрицательного ввода числа для определения длины строки;
string str = Convert.ToString(number);
int size = str.Length;
int [] numbers = new int[size];
int sum = 0;
int temval = 0;
int index = size;
int printnum = number;
while (index > 0 )  // внесение цифр из числа в массив (можно конечно не давать право пользователю не вводить число);
    {
        index = index - 1;
        temval = number %10;
        numbers[index] = temval;
        number = number / 10;
    }

for (int i = 0; i < size; i++) // Нахождение суммы цифр массива;
{
    sum = sum + numbers[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма цифр числа {printnum} равна {sum}");