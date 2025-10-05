using System;
using System.Runtime.InteropServices;
class Program
{
    static void Main()
    {
        Console.WriteLine(RetornaDivisores(12));

    }

    static bool VerificaPalindromo(string input)
    {
        int index = input.Length - 1;
        int i = 0;

        if (input[i++] != input[input.Length - 1]) return false;
        else VerificaPalindromo(input = input.Substring(0, input.Length - 1));

        return true;

    }

    static int RetornaDivisores(int n, int divisor = 1)
    {
        int cont = 0;

        if (divisor <= n)
        {
            if (n % divisor == 0)
            {
                cont += 1 + RetornaDivisores(n, ++divisor);
                Console.WriteLine($"{cont} += 1 + {RetornaDivisores(n, divisor)} | divisão testada: {n} / {--divisor} = {1.0 * (n / divisor)}");
                ++divisor;
            }

            else cont += 0 + RetornaDivisores(n, ++divisor);
        }


        return cont;
    }
}