Console.Clear();

int xA = 1;
int yA = 1;
int xB = 1;
int yB = 30;
int xC = 70;
int yC = 30;
Console.SetCursorPosition(xA, yA);
Console.Write("+");
Console.SetCursorPosition(xB, yB);
Console.Write("+");
Console.SetCursorPosition(xC, yC);
Console.Write("+");
int x = xA, y = xB;

int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x+xA)/2;
        y = (y+yA)/2;
    }
    if (what == 1)
    {
        x = (x+xB)/2;
        y = (y+yB)/2;
    }
    if(what == 2)
    {
        x = (x+xC)/2;
        y = (y+yC)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}