using System;
class Program
{
    static readonly Random r = new();
    static void Main()
    {
        int[] v = new int[10];
        System.Console.WriteLine(SomaVetor(v));
    }

    static int[] PreencheVetor(int[] v, int cont = 0)
    {
        if (cont == v.Length) return v;
        else
        {
            v[cont] = r.Next(0, 11);
            return PreencheVetor(v, cont + 1);
        }
    }

    static int SomaVetor(int[] v, int cont = 0, int soma = 0)
    {
        if (cont == v.Length) return soma;
        else
        {
            soma += v[cont++];
            return SomaVetor(v, cont, soma);
        }
    }
}