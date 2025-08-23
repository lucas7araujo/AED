using System;
using System.Linq;
class Program
{
    // Objetivo: Crie um programa que receba uma string e conte quantas vezes cada caractere aparece nela. Exiba o resultado em ordem alfabética dos caracteres.

    static char[] ConverteString(string palavra) => palavra.ToArray();
    static string[] ContaCaracteres(string palavra, char[] letras)
    {

        string[] contagem = new string[letras.Length];
        var index = 0;

        for (int i = 0; i < letras.Length; i++)
        {
            var cont = 0;
            for (int j = 0; j < palavra.Length; j++)
            {
                if (letras[i] == palavra[j]) cont++;
            }
            contagem[index++] = $"Letra {letras[i]} Número de vezes: {cont}";
        }

        return contagem;
    }
    static void ExibeContagem()
    {
        Console.Write("Informe uma palavra: ");
        string palavra = Console.ReadLine();
        Console.Clear();
        char[] letras = ConverteString(palavra);
        string[] contagem = ContaCaracteres(palavra, letras);
        var contagemSemRepetidos = contagem.Distinct();
        Console.Write(string.Join("\n", contagemSemRepetidos));
    }

    static void Main(string[] args)
    {
        Console.Clear();
        ExibeContagem();
        Console.WriteLine();
        Console.ReadKey();
        Console.Clear();
    }
}