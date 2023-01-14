// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
Console.WriteLine("ЭВМ сгенерировал массив из 8 чисел: ");
int [] array = new int[8];

for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(0, 1000);
}

Console.WriteLine($" [ {String.Join(", ", array)} ] "); // Новый способ вывода массива для меня через строку;