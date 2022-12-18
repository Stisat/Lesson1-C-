int number = new Random().Next(1, 100000);
Console.WriteLine($"Компьютер число от 1 до 100000: {number}");
string str = Convert.ToString(number);
int lenstr = str.Length;
// Console.WriteLine(lenstr);
if (lenstr < 3)
{
    Console.WriteLine($"Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра в числе - {str[2]}");
}