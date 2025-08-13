using System;
class Program
{
    //     🔁 2. Sequência de Fibonacci
    // Instrução: Escreva um programa que gere os 20 primeiros números da sequência de Fibonacci. A sequência começa com 0 e 1, e cada número seguinte é a soma dos dois anteriores.

    static void ExibeFibonacci()
    {
        int[] fibonacci = new int[19];
        fibonacci[0] = 0;
        fibonacci[1] = 1;

        for (int i = 2; i < fibonacci.Length; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        Console.WriteLine("Sequência de Fibonacci | 20 primeiros números.");

        foreach (var item in fibonacci)
        {
            Console.Write(item + " ");
        }
    }
    static void Main(string[] args)
    {
        ExibeFibonacci();
    }
}