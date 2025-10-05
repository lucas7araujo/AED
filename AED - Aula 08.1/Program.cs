using System;

class Program
{
    static void Main()
    {
        System.Console.WriteLine(RetornaBinario(63));
        System.Console.WriteLine(RetornaDecimal("111111"));
    }

    static string RetornaBinario(int n)
    {
        if (n == 0) return "0";

        string retorno = "";

        while (n > 0)
        {
            retorno = (n % 2) + retorno;
            n /= 2;
        }

        return retorno;
    }


    static double RetornaDecimal(string binario)
    {
        binario = new string(binario.Reverse().ToArray());

        double expoente = 0;
        double soma = 0;
        for (int i = 0; i < binario.Length; i++)
        {
            double aux = 0;
            aux = Convert.ToInt32(char.GetNumericValue(binario[i]));
            if (aux == 1)
                soma += Math.Pow(2, expoente++);
            if (expoente == 0) soma += Math.Pow(2, expoente++);

        }

        return soma-1;
    }
}
