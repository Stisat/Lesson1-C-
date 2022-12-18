Console.WriteLine("Введите число которое проверям на четность-нечетность: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number = number * -1;
}
if  (number %2 == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число не является четным");
}
