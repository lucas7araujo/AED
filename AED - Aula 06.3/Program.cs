using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        double a, b, c;
        double delta;
        double raiz1 = 0, raiz2 = 0;

        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());

        delta = CalcularDelta(a, b, c);

        if (delta < 0) Console.WriteLine("\nA equação não possui raízes reais.");
        else
        {
            CalcularRaizes(a, b, delta, ref raiz1, ref raiz2);
            Console.WriteLine($"\nRaiz 1 = {raiz1}");
            Console.WriteLine($"Raiz 2 = {raiz2}");
        }

        Console.ReadKey();
    }

    static double CalcularDelta(double a, double b, double c) => Math.Pow(b, 2) - 4 * a * c;

    static void CalcularRaizes(double a, double b, double delta, ref double raiz1, ref double raiz2)
    {
        raiz1 = (b + Math.Sqrt(delta)) / 2 * a;
        raiz2 = (-b + Math.Sqrt(delta)) / 2 * a;
    }
}