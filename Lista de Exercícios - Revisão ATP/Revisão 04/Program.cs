using System;
class Program
{
    static void Main(string[] args)
    {
        int[] vetorA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] vetorB = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int[] vetorResultante = vetorA.Concat(vetorB).ToArray();

        foreach (var item in vetorResultante)
        {
            Console.Write(item + " ");
        }
    }
}