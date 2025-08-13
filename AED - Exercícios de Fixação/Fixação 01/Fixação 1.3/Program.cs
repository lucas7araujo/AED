using System;
using System.Linq;
class Program
{

    // Simulador de Dados
    // Instrução: Simule o lançamento de dois dados (valores de 1 a 6) e exiba o resultado. Repita isso 100 vezes e mostre quantas vezes cada soma possível (de 2 a 12) apareceu.

    static Random r = new Random();
    static int RetornaDados()
    {
        int dado1 = r.Next(1, 7);
        int dado2 = r.Next(1, 7);

        return dado1 + dado2;
    }

    static void RetornaQuantidadeTermos(int[] dados, int x)
    {
        Console.WriteLine($"Número de vezes que tivemos soma {x}: {dados.Count(n => n == x)}");
    }

    static void Main()
    {
        int[] dados = new int[100];

        for (int i = 0; i < dados.Length; i++)
        {
            dados[i] = RetornaDados();
        }

        

        for (int i = 2; i <= 12; i++)
        {
            RetornaQuantidadeTermos(dados, i);
        }

    }
}