Console.Write("Введите первое число: ");
int numFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numSecond = Convert.ToInt32(Console.ReadLine());

if (numFirst == numSecond*numSecond)
    Console.Write($"Число {numFirst} является квадратом {numSecond}");
else 
    Console.Write($"Число {numFirst} не является квадратом {numSecond}");
