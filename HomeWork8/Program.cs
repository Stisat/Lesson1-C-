Console.WriteLine("Введите количество чисел для проверки четный-нечетный: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int index = 0;
int [] array = new int[numbers];
while (index < numbers) // Ввод чисел в массив
{
    Console.WriteLine($"Введите {index+1}) число: ");
    array[index] = Convert.ToInt32(Console.ReadLine());
    index++;
}
index = 0;
Console.WriteLine();
Console.Write("Имеем набор чилес: ");
while (index < numbers) // Вывод чисел массива в консоль ввиде строки
{
    Console.Write($"{array[index]}. ");
    index++;
}
index = 0;
int n = 0;
Console.WriteLine();
Console.WriteLine("Из ведденых числел, четными являются:");
while (index < numbers)
{
    if (array[index] %2 == 0)
    {
        Console.Write($"{array[index]}. ");
        n = n + 1;
    }
    index++;
}
if (n == 0)
{
    Console.Write("Ниодного");
}