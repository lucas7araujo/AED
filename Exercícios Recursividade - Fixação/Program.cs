// 1. Fatorial

// Implemente uma função recursiva que calcule o fatorial de um número inteiro n.
// Exemplo: 5! = 120.

// 2. Sequência de Fibonacci

// Escreva uma função recursiva que calcule o enésimo termo da sequência de Fibonacci.
// Exemplo: Fib(6) = 8.

// 3. Soma dos dígitos

// Crie uma função recursiva que receba um número inteiro positivo e retorne a soma dos seus dígitos.
// Exemplo: Soma(1234) = 10.

// 4. Potência

// Implemente uma função recursiva para calcular a^b (base elevado ao expoente).
// Exemplo: 2^5 = 32.

// 5. Inverter string

// Faça uma função recursiva que inverta uma string.
// Exemplo: "csharp" → "prahs c".

// 6. Contar ocorrências

// Dada uma string e um caractere, crie uma função recursiva que conte quantas vezes o caractere aparece.
// Exemplo: "banana", 'a' → 3.

// 7. Máximo divisor comum (MDC)

// Implemente uma função recursiva para calcular o MDC de dois números inteiros usando o algoritmo de Euclides.
// Exemplo: MDC(48,18) = 6.

// 8. Torres de Hanói

// Escreva uma função recursiva que resolva o problema das Torres de Hanói com n discos. A função deve imprimir os movimentos.

// 9. Percorrer array recursivamente

// Crie uma função recursiva que percorra um array de inteiros e retorne a soma dos elementos.

// 10. Palíndromo

// Faça uma função recursiva que verifique se uma string é um palíndromo (lê-se igual de frente para trás).
// Exemplo: "radar" → true.


using System;
class Program
{
    static void Main()
    {
        // System.Console.WriteLine(ReturnFat(5));
        // System.Console.WriteLine(RetunrFib(6));
        // Console.WriteLine(RetornaPotencia(10, 2));
        Console.WriteLine(InverteString("c sharp"));

    }
    static int ReturnFat(int number)
    {
        if (number == 1) return 1;
        else return number * ReturnFat(number - 1);
    }

    static int RetunrFib(int n)
    {
        if (n == 1 | n == 2) return 1;
        else return RetunrFib(n - 1) + RetunrFib(n - 2);
    }

    static int ReturnSoma(int n)
    {
        return 5; // fzr depois
    }

    static int RetornaPotencia(int a, int b)
    {
        if (a == 1 || b == 0) return 1;
        else
        {
            return a * RetornaPotencia(a, b - 1);
        }
    }

    static string InverteString(string texto, string retorno = "", int count = 1)
    {
        if (texto.Length == retorno.Length) return retorno;
        else
        {
            retorno += texto[texto.Length - count];
            return InverteString(texto, retorno, count + 1);
        }
    }

}