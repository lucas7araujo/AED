using System;
class Program
{
    static void Main()
    {
        System.Console.WriteLine(SomaDividores(4));
    }

    static int SomaDividores(int n, int divisor = 1, int somaDiv = 0)
    {
        if (n == divisor) return somaDiv;
        else
        {
            if (n % divisor == 0)
            {
                somaDiv += divisor;
                return SomaDividores(n, divisor + 1, somaDiv);
            }
            else
            {
                return SomaDividores(n, divisor + 1, somaDiv);
            }
        }
    }
}