using System;
using System.Linq;
class Program
{
    static void LerNumero(out int numero)
    {
        Console.Write("Informe um número: ");
        numero = int.Parse(Console.ReadLine());
    }

    static bool VerificaPalindromo(int numero)
    {
        string numeroEmTexto = numero.ToString();
        string numeroEmTextoInvertido = string.Join("", numeroEmTexto.ToString().Reverse());
        return numeroEmTextoInvertido == numeroEmTexto;

    }
    static void Main()
    {
        // LerNumero(out int numero);
        Console.WriteLine(VerificaPalindromo(1234554321));
    }
}