using System;

namespace AlunoApp
{
    public class Aluno
    {
        public string Nome { get; set; } = string.Empty;
        public string Mail { get; set; } = string.Empty;
        public string DataDeNascimento { get; set; } = string.Empty;
        public string NumeroTelefone { get; set; } = string.Empty;

        public Aluno(string Nome, string Mail, string DataDeNascimento, string NumeroTelefone)
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
}