using System;
class Program
{
    static void Main()
    {
        // 2.	Faça um programa que mostre os   primeiros termos da Série de Fibonacci, com   obrigatoriamente maior que 2 :    
        Console.Write("Quantos dígitos da sequência de Fibonacci deseja armazenar? ");
        var n = int.Parse(Console.ReadLine());

        while (n < 2)
        {
            Console.Write("Informe um número maior que 2: ");
            n = int.Parse(Console.ReadLine());
        }

        int[] fibonacci = RetornaFibonacci(n);

        Console.WriteLine(string.Join(" | ", fibonacci));

    }

    static int[] RetornaFibonacci(int n)
    {
        int[] fibonacci = new int[n];
        fibonacci[0] = 0;
        fibonacci[1] = 1;

        for (int i = 2; i < n; i++)
        {
            fibonacci[i] += fibonacci[i - 1] + fibonacci[i-2];    
        }
        

        return fibonacci;
    } 
}

