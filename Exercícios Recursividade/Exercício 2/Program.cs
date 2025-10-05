using System;
class Program
{
    static void Main()
    {
        int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        Console.WriteLine(ReturnMinValue(v));
    }

    static int ReturnMinValue(int[] v, int cont = 0, int minValue = int.MaxValue)
    {
        if (cont == v.Length) return minValue;

        if (v[cont] < minValue)
        {
            minValue = v[cont];
        }

        return ReturnMinValue(v, cont + 1, minValue);
    }
}