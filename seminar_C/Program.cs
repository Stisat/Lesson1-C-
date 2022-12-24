// Console.Write("Введите первое число: ");
// int numFirst = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int numSecond = Convert.ToInt32(Console.ReadLine());

// if (numFirst == numSecond*numSecond)
//     Console.Write($"Число {numFirst} является квадратом {numSecond}");
// else 
//     Console.Write($"Число {numFirst} не является квадратом {numSecond}");

// Семинар от 24.12.2022

// Функция - подпрограмма, выполняющая какие-либо операции и возвращающая значение.
// Процедура - подпрограмма, которая только выполняет операции, без возврата значения.
// Метод - это функция или процедура, которая принадлежит классу или экземпляру класса.

// void quarter(int CorX, int CorY)
// {
//     if ((CorX > 0) && (CorY > 0))
//     {
//         Console.WriteLine("Точка расположена в первой четверти координат");
//     }
//     else if ((CorX < 0) && (CorY > 0))
//     {
//         Console.WriteLine("Точка расположена во второй четверти координат");
//     }
//     else if ((CorX < 0) && (CorY < 0))
//     {
//         Console.WriteLine("Точка расположена в третьей четверти координат");
//     }
//     else if ((CorX > 0) && (CorY < 0))
//     {
//         Console.WriteLine("Точка расположена в четвертой четверти координат");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }


// Console.WriteLine("Введите кординаты точки X и Y для нахождения в какой четверти находится точка: ");
// Console.WriteLine("Введите кординату X ");
// int num_x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кординату Y ");
// int num_y = Convert.ToInt32(Console.ReadLine());
// quarter(num_x, num_y);


Console.WriteLine("Введите кординату X точки A");
int num1_x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату Y точки А");
int num1_y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату X точки B");
int num2_x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату Y точки B");
int num2_y = Convert.ToInt32(Console.ReadLine());
int lenAxBx = Math.Abs(num1_x - num2_x);
int lenAyBy = Math.Abs(num1_y - num2_y);

double lenV = Math.Sqrt(Math.Pow((lenAxBx), 2) + Math.Pow((lenAyBy), 2));
Console.WriteLine(lenV);

Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1 )
{
    Console.WriteLine($"X>0 и Y>0");
}
else if (num == 2)
{
    Console.WriteLine($"X>0 и Y<0");
}
else if (num == 3)
{
    Console.WriteLine($"X<0 и Y<0");
}
else if (num == 4)
{
    Console.WriteLine($"X>0 и Y<0");
}
else
{
    Console.WriteLine($"не существует");
}
//

//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// Console.Clear();
// Console.Write("Введите X1: ");
// int x1=int.Parse(Console.ReadLine());
// Console.Write("Введите Y1: ");
// int y1=int.Parse(Console.ReadLine());
// Console.Write("Введите X2: ");
// int x2=int.Parse(Console.ReadLine());
// Console.Write("Введите Y2: ");
// int y2=int.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));

// Console.WriteLine($"d={d:f5}");


//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.

// Console.Clear();
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());

// for(int i = 1; i <= N; i++)
// {
//     Console.Write($"{i*i} ");
// }