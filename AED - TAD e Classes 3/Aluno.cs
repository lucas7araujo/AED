using System;

namespace AlunoApp
{
    public class Aluno
    {
        public string? Nome { get; set; } = string.Empty;
        public string? Mail { get; set; } = string.Empty;
        public DataDeNacimento? DataDeNascimento { get; set; }
        public string? NumeroTelefone { get; set; } = string.Empty;

        public Aluno(string Nome, string Mail, DataDeNacimento DataDeNascimento, string NumeroTelefone)
        {
            this.Nome = Nome;
            this.Mail = Mail;
            this.DataDeNascimento = DataDeNascimento;
            this.NumeroTelefone = NumeroTelefone;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nEmail: {Mail}\nData de nascimento: {DataDeNascimento}\nNúmero de telefone: +55 31 {NumeroTelefone}";
        }
    }

    public class DataDeNacimento
    {
        public string? Dia { get; set; } = string.Empty;
        public string? Mes { get; set; } = string.Empty;
        public string? Ano { get; set; } = string.Empty;

        public DataDeNacimento(string Dia, string Mes, string Ano)
        {
            this.Dia = Dia;
            this.Mes = Mes;
            this.Ano = Ano;
        }

        public override string ToString()
        {
            return $"{Dia}/{Mes}/{Ano}";
        }

    }
}