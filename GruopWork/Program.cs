// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);

// int Firstnum = number / 100;
// int Varnum = (number/10);
// int Secondnum = number - Varnum*10;
// int FinalNum = Firstnum*10 + Secondnum;

// Console.WriteLine(FinalNum);

// Console.WriteLine("Введите первое число ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 % number2 == 0)
// {
//     Console.Write("Второе число кратно первому");
// }
// else
// {
//     Console.Write($"Второе число не кратно первому, остаток равен {number1 % number2}");

// }


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if ((number %7 == 0 ) & (number %23 == 0))
// {
//     Console.WriteLine($"Число {number} кратно 7 и 23");
// }
// else
// {
//     Console.WriteLine($"Число {number} не кратно 7 и 23");
// }


Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if ((number2 /number1 == number1) || (number1 /number2 == number2))
{
    Console.WriteLine(" Одно число является квадратом числа другого");
}
else
{
    Console.WriteLine("нет таких)");
}