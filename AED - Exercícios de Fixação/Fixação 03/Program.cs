using System;

class Program
{
    static int RetornaFatorial(int n)
    {
        var soma = 1;
        for (int i = 1; i <= n; i++)
        {
            soma *= i;
        }

        return soma;
    }

    static int RetornaSuperFatorial(int n)
    {
        var soma = 1;
        for (int i = 1; i <= n; i++)
        {
            soma *= RetornaFatorial(i);
        }
        System.Console.WriteLine(soma);
        return soma;
    }
    static void Main()
    {
        RetornaSuperFatorial(4);
    }
}