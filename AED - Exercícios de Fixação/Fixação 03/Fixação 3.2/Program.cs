using System;
using System.Linq;

class Program
{
    //    Por meio de funções faça um programa que sorteie elementos de um vetor de tamanho “T”
    // fornecido pelo usuário e inverta a ordem de seus elementos.

    static Random r = new Random();

    static int[] RetornaVetor(int[] v)
    {
        for (int i = 0; i < v.Length; i++)
        {
            v[i] = r.Next(5, 100);
            Console.Write(v[i] + " ");
        }

        return v;
    }

    // Com Linq
    static int[] InverteVetorComLinq(int[] v) => v.Reverse().ToArray();

    // Sem Linq
    static int[] InverteVetorSemLinq(int[] v)
    {
        var indice = 0;
        for (int i = v.Length - 1; i >= 0; i--)
        {
            var aux = 0;
            aux = v[i];
            v[indice++] = aux;
        }

        return v;
    }

    static void Main()
    {
        Console.Write("Informe o valor do Vetor T: ");
        int t = int.Parse(Console.ReadLine());
        int[] v = new int[t];
        RetornaVetor(v);
        int[]comLinq = InverteVetorComLinq(v);
        int []semLinq = InverteVetorSemLinq(v);

        Console.WriteLine("Vetor Original: " + string.Join(" | ", v));
        Console.WriteLine("Com Linq: " + string.Join(" | ", comLinq));
        Console.WriteLine("Sem Linq: " + string.Join(" | ", semLinq));
    }
}