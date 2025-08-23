using System;
class Program
{
    static Random r = new Random();
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

    static int[,] InverteMatriz(int[,] m)
    {
        int[,] mAux = new int[m.GetLength(1), m.GetLength(0)];
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                mAux[j, i] = m[i, j];
            }
        }

        return mAux;
    }


    static void ExibeMatriz(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write($"{m[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {

        Console.Clear();
        Console.Write("Informe o número de Linhas da Matriz Original: ");
        var linhas = int.Parse(Console.ReadLine());

        Console.Write("Informe,agora, o número de colunas da Matriz Original: ");
        var colunas = int.Parse(Console.ReadLine());

        int[,] matrizOriginal = new int[linhas, colunas];
        int[,] matrizTransposta = new int[colunas, linhas];

        Console.Clear();

        PreencheMatriz(matrizOriginal);
        ExibeMatriz(matrizOriginal);
        System.Console.WriteLine();
        matrizTransposta = InverteMatriz(matrizOriginal);
        ExibeMatriz(matrizTransposta);




    }
}