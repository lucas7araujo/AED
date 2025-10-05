using System;
class Program
{
    static void Main()
    {
        System.Console.WriteLine(VerificaPalindromo("ana"));
        System.Console.WriteLine(VerificaPalindromo2("subinoonibus"));
    }

    static bool VerificaPalindromo(string palavra) => palavra == new string(palavra.Reverse().ToArray());
    static bool VerificaPalindromo2(string palavra)
    {
        for (int i = 0; i < palavra.Length / 2; i++)
        {
            if (palavra[i] != palavra[palavra.Length - 1 - i])
                return false;
        }
        return true;
    }
}
