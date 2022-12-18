int number = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерировано трехзначное число: {number}");

int n1 = number /100;
int n3 = number %10;
int n2 = (number - n1*100 -n3) /10;
Console.WriteLine();
Console.WriteLine($"Вторая цифра этого числа - {n2}");