Console.WriteLine("Введите любою цифру, обозначающую день недели от 1 до 7:");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 7) 
{
Console.WriteLine("Вы ушли за пределы одной недели");
}
else
{
    if ((day == 6) || (day == 7)) // обычная проверка 7 дней в неделе.
    {
        Console.WriteLine("Выходной день");
    }
    else Console.WriteLine("Будний день");
}