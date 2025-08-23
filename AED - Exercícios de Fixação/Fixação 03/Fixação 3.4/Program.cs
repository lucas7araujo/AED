using System;
// "Encontre todos os números entre 0 e 999 onde a soma dos quadrados dos dígitos seja igual ao número de dígitos vezes 9."
class Program
{
    static double RetornaSomaQuadrados(int n)
    {
        int c = n / 100;
        int d = n / 10 % 10;
        int u = n % 100 % 10;

        return c * c + d * d + u * u;
    }

    static int RetornaNumeroDigitos(int n)
    {
        string aux = n.ToString();
        return aux.Length;
    }

    static bool VerificaCondicao(int n) => RetornaSomaQuadrados(n) == RetornaNumeroDigitos(n) * 9;

    static List<int> RetornaLista()
    {
        var lista = new List<int>();

        for (int i = 0; i <= 999; i++)
        {
            if (VerificaCondicao(i)) lista.Add(i);
        }

        return lista;
    }
    static void Main()
    {
        var lista = new List<int>();
        lista = RetornaLista();

        foreach (var item in lista)
        {
            Console.Write(item + " ");
        }
    }
}