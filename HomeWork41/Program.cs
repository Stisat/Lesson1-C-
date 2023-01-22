// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] Mnumbers(int numberM)
{
    int[] arrayM = new int[numberM];
    for (int i = 0; i < numberM; i++)
    {
        Console.Write($"Введите число {i + 1}) ");
        arrayM[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arrayM;
}

int FindPositiveNumber(int[] array)
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] arrM = Mnumbers(M);
Console.WriteLine($"[ {String.Join(", ", arrM)} ] ");
Console.WriteLine();
Console.WriteLine($"Количество положительных чисел равно {FindPositiveNumber(arrM)}");