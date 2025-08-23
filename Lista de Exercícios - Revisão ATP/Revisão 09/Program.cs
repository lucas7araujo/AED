using System;
class Program
{
    // 9.	Faça um programa que receba uma matriz quadrada de ordem 3 e chame uma função que seja capaz de retornar um vetor somente com os elementos que estão acima ou abaixo de sua diagonal principal.

    static readonly Random r = new();
    static void Main(string[] args)
    {
        Console.Clear();
        int[,] matriz = new int[3, 3];
        int[] vetorDiagonalPrincipal = new int[matriz.GetLength(0)];
        PreencheMatriz(matriz);
        ExibeMatriz(matriz);
        RetornaVetorDiagonalPrincipal(matriz, vetorDiagonalPrincipal);
        Console.WriteLine("\nVetor da diagonal principal\n" + string.Join(" ", vetorDiagonalPrincipal));
        Console.ReadKey();
        Console.Clear();

    }

    static void PreencheMatriz(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                m[i, j] = r.Next(1, 10);
            }
        }
    }

    static void ExibeMatriz(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write(m[i, j] + "   ");
            }

            Console.WriteLine();
        }
    }

    static void RetornaVetorDiagonalPrincipal(int[,] m, int[] v)
    {
        var index = 0;
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                if (i == j) v[index++] = m[i, j];
            }
        }
    }
}
