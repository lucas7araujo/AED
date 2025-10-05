using System;
using System.Linq;
class Program
{
    // 6.	Dados dois vetores R e S, cada um com 10 posições. Faça um algoritmo que leia os valores de R e S e gere o vetor V resultante da união dos dois, sem elementos repetidos.
    static void Main(string[] args)
    {
        int[] r = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
        int[] s = { 1, 2, 13, 4, 5, 16, 7, 83, 9, 0 };

        var v = r.Concat(s).Distinct().OrderBy(n => n).ToArray();
        Console.Clear();
        Console.WriteLine("Vetor Resultante da União:");
        Console.WriteLine(string.Join(" ", v));
        Console.ReadKey();
    }
}
