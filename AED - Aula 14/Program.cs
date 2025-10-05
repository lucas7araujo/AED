using System;

namespace WorkBJA
{

    class Professor
    {
        public string Nome;
        public DateTime DataNascimento = DateTime.Now;

        public Professor(string nome)
        {
            this.Nome = nome;
        }

        public override string ToString()
        {
            return $"Professor: {Nome} - Nascimento: {DataNascimento}";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new("Lucas");

            Console.WriteLine(professor);

            // Professor[] CadProf = new Professor[3];

            // for (int i = 0; i < CadProf.Length; i++)
            // {
            //     Console.Write("Nome do professor: ");
            //     professor.Nome = Console.ReadLine();

            //     Console.Write("Data de nascimento do professor: ");
            //     professor.DataNascimento = Console.ReadLine();

            //     CadProf[i] = professor;
            // }

            // Console.Clear();

            // foreach (var prof in CadProf)
            // {
            //     Console.WriteLine(prof);
            // }

            Console.ReadKey();
        }
    }
}