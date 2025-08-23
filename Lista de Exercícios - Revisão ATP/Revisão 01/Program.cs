using System;
class Program
{
    static double ResultadoSerieA(int n)
    {
        double soma = 0;
        for (double i = 1; i <= n; i++)
        {
            soma += (i - 1) / i;
        }
        return soma;
    }

    static int ResultadoSerieB(int n)
    {
        var soma = 100;
        var operador = 1;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{soma} {((operador > 0)? "-" : "+")} {i}");
            if (operador > 0) soma -= i;
            else if (operador < 0) soma += i;

            operador *= -1;
        }

        return soma;
    }
    static void Main()
    {
        Console.Clear();
        System.Console.WriteLine(ResultadoSerieA(20));
        System.Console.WriteLine(ResultadoSerieB(30));
    }
}