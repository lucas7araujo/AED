using System;
class Program
{
    // Exercício 2: Sequência de Collatz
    // Objetivo: Dada uma entrada numérica, gerar a sequência de Collatz até chegar em 1. A regra é:

    // Se o número for par, divida por 2.

    // Se for ímpar, multiplique por 3 e some 1.

    static void SequenciaCollatz(int n)
    {
        var numero = n;
        var cont = 1;

        do
        {
            if (numero % 2 == 0) numero /= 2;
            else if (numero % 2 != 0) numero = numero * 3 + 1;

            Console.WriteLine($"Número {cont++} da sequência: {numero}");

        } while (numero != 1);

        Console.WriteLine($"Número de tentativas: {cont}");
    }
    static void Main(string[] args)
    {
        Console.Clear();
        SequenciaCollatz(89);
    }
}