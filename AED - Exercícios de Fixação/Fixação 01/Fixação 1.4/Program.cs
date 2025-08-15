using System;
using System.Linq;

class Program
{

    //     🔄 Desafio: Gerador de Palíndromos com Soma Reversa
    // Objetivo: Crie um programa que receba um número inteiro positivo e aplique o seguinte processo até encontrar um palíndromo:

    // Inverta os dígitos do número.

    // Some o número original com seu reverso.

    // Verifique se o resultado é um palíndromo.

    // Se não for, repita o processo com o novo número.

    // Quando encontrar um palíndromo, exiba:

    // O número final.

    // A quantidade de tentativas realizadas.

    static int InverteNumero(int n)
    {
        string auxiliar = string.Join("", n.ToString().Reverse());
        return int.Parse(auxiliar);
    }

    static bool VerificarPalindromo(int n)
    {
        string auxiliar = string.Join("", n.ToString());

        return (auxiliar == string.Join("", auxiliar.Reverse()));
    }

    static (int, int) VerificaSomas(int y)
    {
        int x = InverteNumero(y);
        var tentativas = 0;

        var soma = 0;

        do
        {
            soma = 0;
            soma = y + InverteNumero(y);
            tentativas++;

            Console.WriteLine($"Soma -> {y} + {InverteNumero(y)} = {soma}");

            if (!VerificarPalindromo(soma)) y = soma;

        } while (!VerificarPalindromo(soma));

        return (soma, tentativas);

    }
    static void Main()
    {
        int soma, tentativas;
        (soma, tentativas) = VerificaSomas(73);
        Console.WriteLine($"Soma: {soma} | Tentativas: {tentativas}");
    }
}