using System;
class Program
{
    //     12.	Faça um programa que receba uma matriz de ordem 2 x 5 e o valor de um escalar K. A função deve receber a matriz e mostrar o resultado dela multiplicada por este escalar.
    static void Main(string[] args)
    {
        int[,] m = new int[2, 5];
        int escalarK = -1;
        Console.Clear();

        PreencheMatriz(m);
        Console.WriteLine();
        ExibeMatriz(m);
        Console.WriteLine();
        ExibeMatrizMultiplicada(m, escalarK);
        Console.ReadKey();
        Console.Clear();
    }

    static readonly Random r = new();

    static void PreencheMatriz(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                m[i, j] = r.Next(0, 10);
            }
        }
    }

    static void ExibeMatriz(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write(m[i, j] + "       ");
            }
            Console.WriteLine();
        }
    }
    static void ExibeMatrizMultiplicada(int[,] m, int escalarK)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write(m[i, j] * escalarK + "       ");
            }
            Console.WriteLine();
        }
    }

}