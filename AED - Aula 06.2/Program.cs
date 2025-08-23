using System;


class Program
{
    static readonly Random r = new();

    static void PreencheMatriz(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                m[i, j] = r.Next(0, 9);
            }
        }
    }

    static void ExibeMatriz(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write($"{m[i, j], -8}");
            }
        }
    }

    static int RetornaOcorrencia(int n, int[,] m)
    {
        var cont = 0;
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                if (m[i, j] == n) cont++;
            }
        }
        return cont;
    }

    static void ExibeOcorrencias(int[,] m)
    {
        for (int i = 0; i <= 9; i++)
        {
            Console.WriteLine($"Número de ocorrências do número {i}: {RetornaOcorrencia(i, m)} ");
        }
    }
    static void Main()
    {
        int[,] matriz = new int[4, 4];
        PreencheMatriz(matriz);
        ExibeMatriz(matriz);
        ExibeOcorrencias(matriz);

    }
}