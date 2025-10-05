using System;
using FilmeApp;
class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        Filme[] filmes = new Filme[5];

        for (int i = 0; i < filmes.Length; i++)
        {
            Console.Write("Informe o nome do filme: ");
            string? nomeFilme = Console.ReadLine();

            Console.Write("Informe a duração do filme em minutos: ");
            int duracao = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Informe o nome do diretor: ");
            string? nomeDiretor = Console.ReadLine();

            Console.Write("Escolha a categoria do filme:\n\n0 - Comédia\n1 - Terror\n2 - Ação\n3 - Romance\n-> ");
            int categoriaFilme = int.Parse(Console.ReadLine() ?? "0");

            filmes[i] = new Filme(nomeFilme!, duracao, nomeDiretor!, categoriaFilme);
            Console.Clear();
        }


        Console.Write("Escolha a categoria do filme que deseja consultar :\n\n0 - Comédia\n1 - Terror\n2 - Ação\n3 - Romance\n-> ");
        int categoriaParaPesquisa = int.Parse(Console.ReadLine() ?? "0");

        Filme.CategoriaFilme categoria = (Filme.CategoriaFilme)categoriaParaPesquisa;

        Console.WriteLine($"\nFilmes da categoria {categoria}:\n");

        foreach (var filme in filmes)
        {
            if (filme.CategoriaDoFilme == categoria)
            {
                Console.WriteLine("\n-------------------------------\n\n");
                Console.WriteLine(filme);
            }
        }

        Console.ReadKey();
        Console.Clear();

    }
}