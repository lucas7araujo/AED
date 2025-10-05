// 6.	Faça uma função recursiva que conte quantos números pares um vetor de 10 posições de números aleatórios possui.

using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
class Program
{
    static readonly Random r = new();
    static void Main()
    {
        int[] v = new int [10];
        PreencheVetor(v);
        System.Console.WriteLine(RetornaPares(v));
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

    static int RetornaPares(int[] v, int cont = 0, int contPares = 0)
    {
        if (cont == v.Length) return contPares;
        else
        {
            if (v[cont] % 2 == 0)
            {
                return RetornaPares(v, cont + 1, contPares + 1);
            }
            else return RetornaPares(v, cont + 1, contPares);
        }
    }
}