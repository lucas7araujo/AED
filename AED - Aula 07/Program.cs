using System;
using System.Collections.Concurrent;
using System.Linq;
class Program
{
    static readonly Random r = new();
    static void Main(string[] args)
    {
        Console.Clear();
        int[] vetor = new int[3];
        PreencheVetor(vetor);

        int cont = 0;
        bool condicao;

        do
        {
            PreencheVetor(vetor);
            condicao = VerificaOrdem(vetor);
            cont++;
        } while (!condicao);

        Console.WriteLine("Vetor Original: " + string.Join(" ", vetor));
        Console.WriteLine("Vetor em Ordem Crescente: " + string.Join(" ", vetor.OrderBy(x => x)));
        Console.WriteLine("Logo, a operação lógica Vetor == Vetor em ordem crescente resulta em: " + condicao);
        Console.WriteLine("Número de sorteios até a ordem crescente ser natural: " + cont);


        Console.WriteLine("Número de sorteios até a ordem crescente ser natural: " + cont);


    }

    static void PreencheVetor(int[] v)
    {
        for (int i = 0; i < v.Length; i++) v[i] = r.Next(0, 9);
    }

    static bool VerificaOrdem(int[] v) => v.OrderBy(x => x).ToArray() == v;
}