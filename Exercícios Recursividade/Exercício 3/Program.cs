using System;
class Program
{
    static void Main()
    {
        string i = "Lucas";
        Console.WriteLine(InvertString(i));
    }

    static string InvertString(string based, int cont = 0)
    {
        if (cont == based.Length - 1)
        {
            return based[cont].ToString();
        }

        return InvertString(based, cont + 1) + based[cont];
    }
}
