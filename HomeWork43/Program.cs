// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void CrossLinePoint (double [] col)
{
    double x = (col[2] - col[0])/(col[1]-col[3]); //x=(b2-b1)/(k1-k2)
    double y = col[3] * x + col[2]; // y= k2*x+b2
    Console.WriteLine($"точка пересечения прямых по координатам х={x:f2}, y={y:f2}");
}

double [] EnterVar (int z)
{
    int size = z;
    double [] arrayBK = new double[size];
    int j = 0;
    for (int i = 0; i < size /2; i++)
    {
        Console.WriteLine($"Введите значение b{i+1}: ");
        arrayBK[i+j] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Введите значение k{i+1}: ");
        arrayBK[i+1+j] = Convert.ToInt32(Console.ReadLine());
        j++;
    }
    return arrayBK;
}
Console.Clear();
double [] varArray = EnterVar(4);
CrossLinePoint(varArray);