Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
int min = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;
if (num2 < min) min = num2;
if (num3 < min) min = num3;

Console.WriteLine($"Минимальное число:  {min}");
Console.WriteLine($"Максимальное число:  {max}");