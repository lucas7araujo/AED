using System;

class Program
{
    static void RetornaDados(out int ano, out int alturaA, out int alturaB, out int taxaCrescimentoA, out int taxaCrescimentoB)
    {
        Console.Write("Informe o ano em que será iniciada a análise: ");
        ano = int.Parse(Console.ReadLine());

        Console.Write("Informe a altura da árvore A: ");
        alturaA = int.Parse(Console.ReadLine());

        Console.Write("Informe a altura da árvore B: ");
        alturaB = int.Parse(Console.ReadLine());

        Console.Write("Informe a taxa de crescimento da árvore A (m): ");
        taxaCrescimentoA = int.Parse(Console.ReadLine());

        Console.Write("Informe a taxa de crescimento da árvore B (m): ");
        taxaCrescimentoB = int.Parse(Console.ReadLine());
    }

    static int RetornaAno(int alturaA, int taxaCrescimentoA, int alturaB, int taxaCrescimentoB, int ano)
    {
        if (taxaCrescimentoA >= taxaCrescimentoB) return 0;

        do
        {
            alturaA += taxaCrescimentoA;
            alturaB += taxaCrescimentoB;
            ano++;
        } while (alturaA >= alturaB);

        Console.WriteLine($"Altura das árvores no ano de ultrapassagem: | A: {alturaA}, B: {alturaB}");

        return ano;

    }

    // git commit -m "feat: Implementa uma nova funcionalidade ao 
    // código."
    // git commit -m "fix: Corrige alguma estrutura
    // já existente."
    // git commit -m "chore: indica mudanças no
    // projeto que não afetem o sistema."
    static void Main()
    {
        // Entradas -> Ano | Altura | Taxa de Crescimento
        // int ano = 2025, alturaA = 40, alturaB = 15, taxaCrescimentoA = 25, taxaCrescimentoB = 35;
        RetornaDados(out int ano, out int alturaA, out int alturaB, out int taxaCrescimentoA, out int taxaCrescimentoB);
        int anoDeUltrapassagem = RetornaAno(alturaA, taxaCrescimentoA, alturaB, taxaCrescimentoB, ano);

        Console.WriteLine(
            (anoDeUltrapassagem != 0) ? $"Ano de ultrapassagem: {anoDeUltrapassagem}" : "A árvore B nunca será maior que a árvore A."
        );


    }
}