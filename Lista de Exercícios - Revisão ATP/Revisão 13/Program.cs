using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
class Program
{
    // 13.	Faça um programa que receba o nome e a nota de 50 alunos. O programa deve chamar uma primeira função que calcule a média geral da turma, e uma segunda função para calcular quem tirou a menor e a maior nota. 
    static void Main(string[] args)
    {
        string[] alunos = { "Lucas", "Gabriel", "Adelino" };
        int[] notas = { 10, 8, 9 };
        System.Console.WriteLine(RetornaMedia(notas));
        System.Console.WriteLine(MaiorNota(notas, alunos));
        System.Console.WriteLine(MenorNota(notas, alunos));
    }

    static double RetornaMedia(int[] notas) => notas.Average();
    static string MaiorNota(int[] notas, string[] alunos)
    {
        int indice = Array.IndexOf(notas, notas.Max());
        return alunos[indice];
    }
    static string MenorNota(int[] notas, string[] alunos)
    {
        int indice = Array.IndexOf(notas, notas.Min());
        return alunos[indice];
    }




}