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


// Console.WriteLine("Введите кординату X точки A");
// int num1_x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кординату Y точки А");
// int num1_y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кординату X точки B");
// int num2_x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите кординату Y точки B");
// int num2_y = Convert.ToInt32(Console.ReadLine());
// int lenAxBx = Math.Abs(num1_x - num2_x);
// int lenAyBy = Math.Abs(num1_y - num2_y);

// double lenV = Math.Sqrt(Math.Pow((lenAxBx), 2) + Math.Pow((lenAyBy), 2));
// Console.WriteLine(lenV);

// Console.WriteLine("Введите номер четверти: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 1 )
// {
//     Console.WriteLine($"X>0 и Y>0");
// }
// else if (num == 2)
// {
//     Console.WriteLine($"X>0 и Y<0");
// }
// else if (num == 3)
// {
//     Console.WriteLine($"X<0 и Y<0");
// }
// else if (num == 4)
// {
//     Console.WriteLine($"X>0 и Y<0");
// }
// else
// {
//     Console.WriteLine($"не существует");
// }
// //

// //Напишите программу, которая принимает на вход координаты двух точек
// // и находит расстояние между ними в 2D пространстве.

// // Console.Clear();
// // Console.Write("Введите X1: ");
// // int x1=int.Parse(Console.ReadLine());
// // Console.Write("Введите Y1: ");
// // int y1=int.Parse(Console.ReadLine());
// // Console.Write("Введите X2: ");
// // int x2=int.Parse(Console.ReadLine());
// // Console.Write("Введите Y2: ");
// // int y2=int.Parse(Console.ReadLine());

// // double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));

// // Console.WriteLine($"d={d:f5}");


//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.

// Console.Clear();
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());

// for(int i = 1; i <= N; i++)
// {
//     Console.Write($"{i*i} ");
// }

//Семинар 14.01.2023 Функции

//Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

// int summaA (int number)
// {
//         int result = 0;
//     for (int i = 0; i < number; i++)
// {
//     result = result + i;
// }
//     return result;
// }
// Console.Clear();
// Console.WriteLine("Введите число А");
// int number = Convert.ToInt32(Console.ReadLine());



// Console.WriteLine(summaA(number));

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// Console.WriteLine("Введите число А");
// int number = Convert.ToInt32(Console.ReadLine());
// number = Math.Abs(number);
// string str = Convert.ToString(number);
// int size = str.Length;
// Console.WriteLine(size);
//второе решение:
// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// int c = GetCountNums(num);
// Console.WriteLine($"Количество цифр = {c}");

// Console.WriteLine($"Количество цифр = {GetCountNums(16)}");


// int GetCountNums(int number)
// {
//     int count = 0;
//     while(number>0)
//     {
//         count++;
//         number/=10;
//     }
//     return count;
// }


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int func(int a)
// {
//     int b=1;
//     for (int i=2; i<=a; i++)
// {
//     b *= i;
// }
// return b;
// }

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int a1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(func(a1));


// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// int [] arr = new int[8];

// for (int i = 0; i < 8; i++)
// {
//     arr[i] = new Random().Next(2);
// }
// Console.WriteLine($" / {String.Join(", ", arr)} / ");

//вариант через функцию:
// int[] array = GetBinaryArray(8);
// Console.WriteLine($" [ {String.Join(" // ", array)} ] ");


// int[] GetBinaryArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(2);
//     }

//     return result;
// }


// Семинар 21.01.2023

// int [] BinMass (int size) // Функция задания массива случайных чисел от 0 до 9999 размером size;
// {
//     int [] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(0, 10000);
//     }
//     return result;
// }

// int [] SortArr (int [] collect) // функция сортировки массива (зеркало)
// {
//     int size = collect.Length;
//     int temp = 0;
//     for (int i = 0; i <= size /2 ; i++)
//     {
//         temp = collect[i];
//         collect[i] = collect[(collect.Length -1)-i];
//         collect[(collect.Length-1)-i] = temp;
//     }
//     return collect;
// }
// Console.Clear();
// Console.WriteLine("Введите количестко элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] arr = BinMass(size);
// Console.WriteLine($"[ {String.Join(", ", arr)} ] ");
// Console.WriteLine();
// SortArr(arr);
// Console.WriteLine($"[ {String.Join(", ", arr)} ] ");

// Задача №40 Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.

// Console.WriteLine("Введите число A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число C: ");
// int numC = Convert.ToInt32(Console.ReadLine());
// if ((numA < numB + numC) && (numB < numA + numC) && (numC < numB + numA))
// {
//     Console.WriteLine("Треугольник может существовать");
// }
// else Console.WriteLine("Треугольник не может существовать");

//или через массив и функции
// int[] CreateRandomArray(int N, int start, int end) //создание массива
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array) // показать массив
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string str = String.Empty;
// string temp = String.Empty;
// while (num>0)
// {
//     temp = Convert.ToString(num%2);
//     str = str + temp;
//     temp = String.Empty;
//     num = num/2;
// }
// int size = str.Length;
// string strN = String.Empty;
// for (int i = 0; i < size; i++)
// {
//     //Console.WriteLine(str[size-1-i]);
//     strN = strN + str[size-1-i];
// }
// Console.WriteLine(strN);
// через массив
// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] Revers(int [] array){
    
//     int temp = 0;
    
//     for (int i=0; i < array.Length/2; i++){
//         temp = array[i];
//         array[i] = array[(array.Length - 1) - i];
//         array[(array.Length - 1) - i] = temp;
//     }

//     return array;
// }

// int [] intToBin(int num){
    
//     int temp = num;
//     int count = 0;

//     while(Convert.ToBoolean(temp)){
//         temp /= 2;
//         count++;
//     }


//     int [] array = new int [count];

//     for (int i=0; i < array.Length; i++){
//         array[i] = num%2; 
//         num /= 2;
//     }
        
//     Revers(array);

//     return array;
// }

// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num);
// int [] array = intToBin(num);

// ShowArray(array);

//фибоначи
// Console.WriteLine($"Введите количество чисел Фибоначчи");
// int val_1 = Convert.ToInt32(Console.ReadLine());

// int param_1 = 0;
// int param_2 = 1;
// int temp = param_2;

// temp = param_1 + param_2; //1
// Console.WriteLine(param_1); //0
// Console.WriteLine(param_2); // 1

// for (int i = 0; i < val_1; i++)
// {
//     temp = temp + param_2; // 2
//     param_1 = param_2;
//     param_2 = temp - param_1;

//     Console.WriteLine(temp);
    
// }

