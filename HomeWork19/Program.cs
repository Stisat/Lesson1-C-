// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: "); // программа требует пятизначное число, но код универсальный для любого числа
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number); // исключение проверки количества символов если введут отрицательное число;
string str = Convert.ToString(number);
int size = str.Length;
int [] numAr = new int[size];
int index = size;
int varnum = 0;
int markV = 0;

    while (index >0 )  // внесение каждого числа в массив numAr;
    {
        index = index - 1;
        varnum = number %10;
        numAr[index] = varnum;
        number = number / 10;
    }
                        // проверка чисел в массиве.
    // Console.WriteLine(); 
    // while (index < 5)
    // {
    //     Console.Write($" {numAr[index]}"); 
    //     index++;
    // }
    // Console.WriteLine();

    Console.WriteLine(size / 2); // проверка на палиндром;
    while (index < size/2)
    {
        if (numAr[index] == numAr[size-1-index])
        {
            markV = 1;
            index++;
        }
        else
        {
            markV = 0;
            Console.WriteLine($"Число не является палиндромом");
            break;
        }
    }
    if (markV == 1)
    {
        Console.WriteLine($"Число является палиндромом");
    }
    