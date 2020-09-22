using System;
class HelloWorld
{
    static void Main()
    {
        int u = 50;
        Console.WriteLine("напряжение=" + u);
        int i = 10;
        Console.WriteLine("сила тока = " + i);
        int r;
        r = u / i;
        Console.WriteLine("сопротивление = " + r);
    }
}