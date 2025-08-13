using System;

class Program
{
    static bool VerificaPrimo(int n)
    {
        int divisores = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                divisores++;
            }
        }

        if (divisores == 2) return true;
        else return false;
    }

    static int[] RetornaInteirosPrimos(int[] inteirosPrimos)
    {
        int indiceAuxiliar = 0;
        for (int i = 2; i < 50; i++)
        {
            if (VerificaPrimo(i))
            {
                inteirosPrimos[indiceAuxiliar] = i;
                indiceAuxiliar++;
            }
        }

        return inteirosPrimos;
    }
    static void Main()
    {
        int[] inteirosPrimos = new int[50];
        RetornaInteirosPrimos(inteirosPrimos);

        Console.WriteLine("\nNúmeros primos entre 2 e 50: \n");

        foreach (var item in inteirosPrimos)
        {
            if (item != 0) Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}