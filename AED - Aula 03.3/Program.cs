using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{
    static double RetornaFatorial(int n)
    {
        double soma = 1;
        for (int i = 1; i <= n; i++)
        {
            soma *= i;
        }

        return soma;
    }
    static double RetornaSomaS(int n)
    {
        double soma = 1;
        for (int i = 1; i <= n; i++)
        {
            if (i != 1)
            {
            if (i % 2 == 0) soma += RetornaFatorial(i) / i;
            else soma -= RetornaFatorial(i) / i;
            }
        }

        return soma;
    }
    static void Main()
    {
        // Entrada 5 | Resultado deve ser -18 
        double resultado = RetornaSomaS(5);
        System.Console.WriteLine(resultado);
    }
}