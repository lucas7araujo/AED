using System;
using AlunoApp;
class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new("Lucas", "lucas@gmail.com", "08/08/2006", "31980215875");
        Console.WriteLine(aluno);
    }
}