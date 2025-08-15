using System;
using System.Linq;
class Program
{
    static Random r = new Random();
    static int[] LerVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            var cont = 0;
            var aux = 0;
            do
            {
                aux = r.Next(0, 10);

                if (!vetor.Any(x => x == aux)) { vetor[i] = aux; cont++; }

            } while (cont == 0);
        }
        return vetor;
    }

    static void ImprimirVetor(int[] vetor)
    {
        foreach (var item in vetor)
        {
            if (item != 0) Console.Write(item + " ");
        }
    }
    static int[] RetornaUniao(int[] vetorA, int[] vetorB)
    {
        int[] vetorC = new int[5];
        var indice = 0;
        for (int i = 0; i < vetorA.Length; i++)
        {
            for (int j = 0; j < vetorB.Length; j++)
            {
                if (vetorA[i] == vetorB[j])
                {
                    vetorC[indice] = vetorA[i];
                    indice++;
                }
            }
        }

        return vetorC;
    }

    static int[] RetornaElementosUnicos(int[] vetorA, int[] vetorB)
    {
        int[] vetorD = new int[5];
        var indice = 0;

        for (int i = 0; i < vetorA.Length; i++)
        {
            if (!vetorB.Any(x => x == vetorA[i])) vetorD[indice++] = vetorA[i];
        }

        return vetorD.Take(indice).ToArray();
    }

    static void Main()
    {
        int[] vetorA = new int[5];
        int[] vetorB = new int[5];
        int[] vetorC = new int[5];
        int[] vetorD = new int[5];

        LerVetor(vetorA);
        LerVetor(vetorB);

        vetorC = RetornaUniao(vetorA, vetorB);

        vetorD = RetornaElementosUnicos(vetorA, vetorB);

        /* Ao Invés de usar um foreach para cada vetor,
        recorremos ao método previamente estabelecido.*/
        
        Console.WriteLine("\nVetor A:");
        ImprimirVetor(vetorA);

        Console.WriteLine("\n\nVetor B:");
        ImprimirVetor(vetorB);

        Console.WriteLine("\n\nVetor da Interseção (A V B):");
        ImprimirVetor(vetorC);

        Console.WriteLine("\n\nVetor de Elementos Únicos de A:");
        ImprimirVetor(vetorD);

        Console.WriteLine();

    }
}