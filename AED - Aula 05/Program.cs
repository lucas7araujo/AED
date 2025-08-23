using System;
using System.Runtime.Intrinsics.Arm;
class Program
{
    static void PreencheVetorAlunos(string[] nomeAlunos)
    {

        for (int i = 0; i < nomeAlunos.Length; i++)
        {
            Console.Write($"Informe o nome do aluno {i + 1}: ");
#pragma warning disable CS8601 // Possível atribuição de referência nula.
            nomeAlunos[i] = Console.ReadLine();
#pragma warning restore CS8601 // Possível atribuição de referência nula.
        }

        Console.Clear();



    }

    static void PreencheMatriz(double[,] matrizNotas, string[] nomeAlunos)
    {
        for (int i = 0; i < matrizNotas.GetLength(0); i++)
        {
            Console.WriteLine();
            double somaNotas = 0;

            for (int j = 0; j < matrizNotas.GetLength(1); j++)
            {
                Console.Write($"Informe a nota {j + 1} do {nomeAlunos[i]}: ");
                matrizNotas[i, j] = double.Parse(Console.ReadLine());
                somaNotas += matrizNotas[i, j];
            }
            somaNotas /= matrizNotas.GetLength(1);
            Console.Clear();
            Console.WriteLine($"O aluno {nomeAlunos[i]} ficou com média {somaNotas:F2}");

        }

    }
    static void Main()
    {
        Console.Clear();
        string[] alunos = new string[2];
        double[,] notas = new double[alunos.Length, 3];
        double[] medias = new double[alunos.Length];
        PreencheVetorAlunos(alunos);
        PreencheMatriz(notas, alunos);

        for (int i = 0; i <= notas.GetLength(0); i++)
        {
            double soma = 0;
            Console.WriteLine($"Aluno | {alunos[i]}: ");
            for (int j = 0; j < notas.GetLength(1); j++)
            {
                Console.WriteLine($"Nota 1: {notas[i, j]}");
                soma += notas[i, j];
            }
            medias[i] = soma;
        }

        Console.Clear();
        Console.WriteLine("Média dos alunos");
        foreach (var item in medias)
        {
            System.Console.WriteLine(item);
        }
    }
}