using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o valor de n: ");
        int n = int.Parse(Console.ReadLine()!); // Não contado como atribuição, usado somente para manipular sentenças e operações
        // ========================================================================================================================
        int cont = 0;
        int Q = 0;
        cont++; // int Q = 0

        int i, j;

        // Loop externo
        cont++; // inicialização i = 0
        for (i = 0; i < n; i++)
        {
            cont++; // comparação i < 2

            // Loop interno
            cont++; // inicialização j = 0
            for (j = 0; j < n; j++)
            {
                cont++; // comparação j < 2
                cont++; // avaliação do if
                if(3 % 2 == 0 )
                {
                    Q++; // nunca atende, somente para teste
                }
                // Q++ não executa no melhor caso
                cont++; // incremento j++
            }
            cont++; // última comparação j < 2 que falhou
            cont++; // incremento i++
        }
        cont++; // última comparação i < 2 que falhou

        // =======================================================================================
        double totalEsperado = (3 * Math.Pow(n, 2)) + (4 * n) + 3;

        Console.WriteLine($"Conta realizada: 3x{n}^2 + 4x{n} + 3 = {totalEsperado}");
        Console.WriteLine("Total de operações contadas: " + cont);
    }
}
