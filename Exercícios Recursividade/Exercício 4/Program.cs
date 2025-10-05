using System;
class Program
{
    static void Main()
    {
        Console.Write("Informe o valor da base: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Informe o valor do expoente: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine(CalculaPotencia(x, y));
    }

    static int CalculaPotencia(int x, int y)
    {
        if (y == 0) return 1; 
        return x * CalculaPotencia(x, y - 1); 
    }
}
