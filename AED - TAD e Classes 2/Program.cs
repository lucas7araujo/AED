using System;
using AlunoApp;
class Program
{
    static void Main(string[] args)
    {
        DataDeNacimento dataDeNacimento = new("08", "08", "2006");
        Aluno aluno = new("Lucas", "lucas@gmail.com", dataDeNacimento, "31980215875");
        Console.WriteLine(aluno);
    }
}