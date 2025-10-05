using System;
class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];
        MostraMatriz(matriz);
        PreencheMatriz(matriz);

        System.Console.WriteLine(RetornaPares(matriz));
    }

    static readonly Random r = new();

    static void PreencheMatriz(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++) //  2 (n+1)
        {
            for (int j = 0; i < m.GetLength(1); j++) 
            {
                m[i, j] = r.Next(0, 9);
            }
        }
    }

    static void MostraMatriz(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; i < m.GetLength(1); j++)
            {
                Console.Write(m + "   ");
            }

            System.Console.WriteLine();
        }
    }

    static int[] RetornaPares(int[,] m)
    {
        int[] pares = new int[m.GetLength(0) + m.GetLength(1)];
        int indice = 0;

        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                if (m[i, j] % 2 == 0) pares[indice++] = m[i, j];
            }
        }

        return pares;
    }
}