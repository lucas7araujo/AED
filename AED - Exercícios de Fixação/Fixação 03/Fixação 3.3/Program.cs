using System;

class Program
{
    static (int, int, int) DestrinchaNumero(int n)
    {
        int c = n / 100;
        int d = n / 10 % 10;
        int u = n % 100 % 10;
        return (c, d, u);
    }


    static int RetornaNumeroDeDigitos(int n)
    {
        string aux = string.Join("", n);
        return aux.Length;
    }

    static bool VerificaCondicao(int n)
    {
        int d1, d2, d3;
        (d1, d2, d3) = DestrinchaNumero(n);
        var soma = d1 + d2 + d3;
        return soma == RetornaNumeroDeDigitos(n) * 3;
    }

    static List<int> GerarNumeros(int n)
    {
        var lista = new List<int>();

        for (int i = 0; i < n; i++)
        {
            if (VerificaCondicao(i)) lista.Add(i);
        }

        return lista;
    }

    static void ImprimeLista(List<int> n)
    {
        foreach (var item in n)
        {
            Console.Write(item + " ");
        }
    }
    static void Main()
    {
        var lista = new List<int>();
        lista = GerarNumeros(999);
        ImprimeLista(lista);
    }
}