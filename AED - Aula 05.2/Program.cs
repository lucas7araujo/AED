using System;


class Program
{
    static Random r = new Random();

    static void PreencheMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = r.Next(0, 49);
            }
        }
    }
    static void ExibeMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    static void ProcuraOcorrencias(int[,] matriz)
    {
        var contador = 0;
        Console.Write("Informe o número que procura: ");
        var numeroVerificante = int.Parse(Console.ReadLine());

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == numeroVerificante) contador++;
            }
        }

        int[,] ocorrencias = new int[20, 2];
        var indice = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == numeroVerificante)
                {
                    ocorrencias[indice, i] = i;
                    ocorrencias[indice, j] = j;
                }
                ;
            }
        }

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                System.Console.WriteLine(ocorrencias[i, j]);
            }
        }


        Console.WriteLine($"Vezes em que o número ({numeroVerificante}) foi encontrado: {contador}");
        if (ocorrencias != null)
        {
            Console.Write($"\nPosições: ");

        }
    }
    static void Main()
    {
        int[,] matriz = new int[4, 5];
        PreencheMatriz(matriz);
        Console.Clear();
        ExibeMatriz(matriz);
        ProcuraOcorrencias(matriz);


    }
}
