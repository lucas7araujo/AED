using System;

public class Program
{
    static int Funcao (int x)
    {
        int i = 1;
        if (x < 2){System.Console.WriteLine("Contagem caso 4"); return 4;}
        else { Console.WriteLine("Contagem caso 1"); return i + Funcao(x - 1);}

    }
    static void Main()
    {
        System.Console.WriteLine(Funcao(3));
    }
}