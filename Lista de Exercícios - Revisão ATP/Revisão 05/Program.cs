using System;

class Program
{
    static readonly Random r = new();
    static void Main(string[] args)
    {
        Console.Clear();
        int[,] matrizA = new int[3, 3];
        int[,] matrizB = new int[3, 3];

        PreencheMatriz(matrizA);
        PreencheMatriz(matrizB);

        Console.WriteLine();

        ExibeMatriz(matrizA);
        Console.WriteLine();
        ExibeMatriz(matrizB);

        var somaA = RetornaSomaMatriz(matrizA);
        var somaB = RetornaSomaMatriz(matrizB);
        var diferenca = somaA - somaB;
        if (diferenca < 0) diferenca *= -1;
        Console.WriteLine($"\nSoma Matriz A: {somaA} | Soma Matriz B: {somaB}");
        Console.WriteLine($"Diferença entre as somas das matrizes: {(diferenca)}");
        Console.ReadKey();
    }

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
                Console.Write(m[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    static int RetornaSomaMatriz(int[,] m)
    {
        var soma = 0;
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                soma += m[i, j];
            }
        }
        return soma;
    }
}