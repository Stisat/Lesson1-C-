// Функция занесения любого натурального числа в массив

int [] BinMass (int number)
{
    number = Math.Abs(number);
    string str = Convert.ToString(number);
    int size = str.Length;
    int [] result = new int[size];
    int tempvar = 0;
    for (int i = size-1; i >= 0; i--)
    {
        tempvar = number %10;
        result[i] = tempvar;
        number = number / 10;
    }
    return result;
}  
Console.Clear(); 
int [] array = BinMass(456);
int [] ar2 = BinMass(45632);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");
Console.WriteLine();
Console.WriteLine($" [ {String.Join(", ", ar2)} ] ");
// ________________________________ 