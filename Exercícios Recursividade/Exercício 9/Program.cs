using System;
using System.Runtime.InteropServices;
class Program
{
    static void Main()
    {
        int[,] m = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        int[] v = new int[3];

        v = RetornaDiagonal(m, v);
        Console.WriteLine(MostraDiagonalMatriz(v));
        Console.WriteLine("Soma: " + RetornaSoma(v));

    }

    static int[] RetornaDiagonal(int[,] m, int[] v, int cont = 0)
    {
        if (cont == m.GetLength(0)) return v;

        else
        {
            v[cont] = m[cont, cont];
            return RetornaDiagonal(m, v, cont + 1);
        }
    }

    static string MostraDiagonalMatriz(int[] v, int cont = 0, string saida = "")
    {
        if (cont == v.Length) return saida;
        else
        {
            saida += " - " + v[cont].ToString();
            return MostraDiagonalMatriz(v, cont + 1, saida);
        }
    }

    static int RetornaSoma(int[] v, int cont = 0, int soma = 0)
    {
        if (cont == v.Length) return soma;
        else
        {
            soma += v[cont];
            return RetornaSoma(v, cont + 1, soma);
        }
    }
}