using System;
using System.ComponentModel;

namespace FilmeApp
{
    public class Filme
    {
        public string? NomeFilme { get; set; } = string.Empty;
        public int? DuracaoFilmeEmMinutos { get; set; }
        public string? NomeDiretorFilme { get; set; } = string.Empty;
        public CategoriaFilme CategoriaDoFilme { get; set; } = 0;
        public Filme(string NomeFilme, int DuracaoFilmeEmMinutos, string NomeDiretorFilme, int CategoriaFilme)
        {
            this.NomeFilme = NomeFilme;
            this.DuracaoFilmeEmMinutos = DuracaoFilmeEmMinutos;
            this.NomeDiretorFilme = NomeDiretorFilme;
            this.CategoriaDoFilme = (CategoriaFilme)CategoriaFilme;
        }

        public enum CategoriaFilme
        {
            Comédia = 0,
            Terror,
            Acao,
            Romance
        }

        public override string ToString()
        {
            return $"Filme: {NomeFilme}\n" +
                   $"Duração: {DuracaoFilmeEmMinutos} minutos\n" +
                   $"Diretor: {NomeDiretorFilme}\n" +
                   $"Categoria: {CategoriaDoFilme}";
        }


    }
}