using System;
class Program
{
    static void Main()
    {
        int[,] m = { { 1, 2, 3 }, { 4, 5, 6 } };
        Console.WriteLine(RetornaMaiorPar(m));
    }

    static int RetornaMaiorPar(int[,] m, int linha = 0, int coluna = 0, int maxPar = int.MinValue)
    {
        if (linha == m.GetLength(0))
            return maxPar;

        int atual = m[linha, coluna];

        if (atual % 2 == 0 && atual > maxPar)
            maxPar = atual;

        if (coluna < m.GetLength(1) - 1)
            return RetornaMaiorPar(m, linha, coluna + 1, maxPar);
        else
            return RetornaMaiorPar(m, linha + 1, 0, maxPar);
    }
}
