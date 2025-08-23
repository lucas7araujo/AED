using System;

class Program
{
    static readonly Random r = new();
    // 7.	Faça um programa que leia as notas de 3 provas de 20 alunos e calcule o total de pontos de cada aluno e a média de pontos da turma em cada uma das 3 provas.
    static void Main(string[] args)
    {
        int[,] matriz = new int[5, 3];
        Console.Clear();
        Console.WriteLine("Matriz com as notas dos alunos\n");
        PreencheMatriz(matriz);
        ExibeMatriz(matriz);

        double[] somaNotasALunos = new double[matriz.GetLength(0)];
        double[] mediaDisciplinas = new double[matriz.GetLength(1)];

        PreencheVetoresDeNotasAlunos(somaNotasALunos, matriz);
        PreencheVetoresDeNotasMedias(mediaDisciplinas, matriz);

        Console.WriteLine("\nSoma das notas dos alunos: ");
        Console.WriteLine(string.Join(" ", somaNotasALunos));
        Console.WriteLine("\nMédia das Disciplinas: ");
        Console.WriteLine(string.Join(" ", mediaDisciplinas));

        Console.ReadKey();
        Console.Clear();
    }

    static void PreencheMatriz(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                m[i, j] = r.Next(1, 10);
            }
        }
    }

    static void ExibeMatriz(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write(m[i, j] + "   ");
            }

            Console.WriteLine();
        }
    }

    static void PreencheVetoresDeNotasAlunos(double[] alunos, int[,] m)
    {
        int indiceAluno = 0;

        for (int i = 0; i < m.GetLength(0); i++)
        {
            double aux = 0;
            for (int j = 0; j < m.GetLength(1); j++)
            {
                aux += m[i, j];
            }
            alunos[indiceAluno++] = aux;
        }
    }
    static void PreencheVetoresDeNotasMedias(double[] disciplinas, int[,] m)
    {
        int indiceDisciplina = 0;

        for (int i = 0; i < m.GetLength(1); i++)
        {
            double aux = 0;
            for (int j = 0; j < m.GetLength(0); j++)
            {
                aux += m[j, i];
            }
            disciplinas[indiceDisciplina++] = Math.Round(aux / m.GetLength(0), 2);
        }
    }

}