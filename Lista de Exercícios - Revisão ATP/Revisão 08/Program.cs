using System;
class Program
{
    // 8.	Faça um programa que chame uma função capaz de verificar se um número inteiro de 4 algarismos é palíndromo. Um palíndromo é identificado quando a leitura dele da esquerda para a direita é mesma que da direita para a esquerda, como, por exemplo, 1221, 9889, 1001 etc.
    static void Main()
    {
        Console.Clear();
        int n = 1221;
        int m = 2301;

        System.Console.WriteLine(VerificaPalindromo(n)); // Espera-se True
        System.Console.WriteLine(VerificaPalindromo(m)); // Espera-se False
        Console.ReadKey();
        Console.Clear();
    }

    static bool VerificaPalindromo(int n) => n.ToString() == new string(n.ToString().Reverse().ToArray());
}