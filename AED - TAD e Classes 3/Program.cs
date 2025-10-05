using System;
using AlunoApp;
class Program
{
    static void Main(string[] args)
    {
        Aluno[] alunos = new Aluno[50];

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine("\nInforme os dados do aluno: \n\n========================\n");
            Console.Write("Informe o nome do aluno: ");
            string? nome = Console.ReadLine();
            Console.Write("Informe o email do aluno: ");
            string? email = Console.ReadLine();
            Console.Write("Informe o número de telefone do aluno: ");
            string? numeroTelefone = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("\nInforme os dados do nacimento do aluno: \n\n========================\n");

            Console.Write("Informe o dia de nascimento do aluno: ");
            string? diaNasicmento = Console.ReadLine();
            Console.Write("Informe o mês de nascimento do aluno: ");
            string? mesNascimento = Console.ReadLine();
            Console.Write("Informe o ano de nascimento do aluno: ");
            string? anoNascimento = Console.ReadLine();

            DataDeNacimento data = new(diaNasicmento!, mesNascimento!, anoNascimento!);
            Aluno aluno = new(nome!, email!, data, numeroTelefone!);

            alunos[i] = aluno;

            Console.Clear();
        }

        ListaAlunos(alunos);

        Console.ReadKey();
        Console.Clear();

    }

    static void ListaAlunos(Aluno[] alunos)
    {
        Console.WriteLine("Lista de Alunos\n============================");
        foreach (var aluno in alunos)
        {
            Console.WriteLine( "\n--------------------\n\n" + aluno);
        }
    }
}