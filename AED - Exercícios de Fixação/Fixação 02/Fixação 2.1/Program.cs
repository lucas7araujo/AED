using System;
class Program
{
    static bool CalculoCubos(int n)
    {
        int c = n / 100;
        int d = (n - c * 100) / 10;
        int u = n % 10;
        double aux = Math.Pow(c, 3) + Math.Pow(d, 3) + Math.Pow(u, 3);
        return aux == n;
    }

    static int[] VerificaNumerosComCondicao(int[] numeros)
    {
        var indice = 0;
        for (int i = 100; i <= 999; i++)
        {
            if (CalculoCubos(i))
            {
                numeros[indice] = i;
                indice++;
            }
        }

        return numeros;
    }
    static void Main()
    {
        // Entrada -> N (Ex: 153) | Processamento -> 1^3 + 5^3 + 3^3 = ? | Saída bool (Entrada == Processamento)
        int[] numeros = new int[999 - 100];
        VerificaNumerosComCondicao(numeros);

        foreach (var item in numeros)
        {
            if (item != 0) Console.Write(item + " ");
        }

    }
}