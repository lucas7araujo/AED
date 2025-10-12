using System;
using System.Security.Cryptography.X509Certificates;

public class Matriz
{
    public int TamanhoLinha { get; set; }
    public int TamanhoColuna { get; set; }

    public int[,] m { get; set; }

    private readonly static Random random = new();

    public Matriz(int TamanhoLinha = 10, int TamanhoColuna = 10, int N = 0)
    {
        this.TamanhoColuna = TamanhoColuna;
        this.TamanhoLinha = TamanhoLinha;
        m = new int[TamanhoLinha, TamanhoColuna];

        if (N > 0)
        {
            for (int i = 0; i < TamanhoLinha; i++)
            {
                for (int j = 0; j < TamanhoColuna; j++)
                {
                    m[i, j] = random.Next(1, N);
                }
            }
        }
    }

}

public class Program
{
    public static int[] DiagPrinc(Matriz matriz)
    {
        int[,] m = matriz.m;

        int[] v = new int[m.GetLength(0)];

        for (int i = 0; i < m.GetLength(0); i++)
        {
            v[i] = m[i, i];
        }

        return v;
    }
    static void Main()
    {
        Matriz m = new (10,3, 9)
    }
}
