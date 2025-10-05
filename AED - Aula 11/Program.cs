using System;
using BCrypt.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite sua senha: ");
        string senha = Console.ReadLine();

        // Gera o hash da senha com fator de trabalho 12
        string hash = BCrypt.Net.BCrypt.HashPassword(senha, workFactor: 31);

        Console.WriteLine($"\nSenha registrada com sucesso!");
        Console.WriteLine($"Hash gerado: {hash}");

        // Exemplo de verificação
        Console.Write("\nDigite a senha novamente para verificar: ");
        string senhaVerificar = Console.ReadLine();

        bool senhaCorreta = BCrypt.Net.BCrypt.Verify(senhaVerificar, hash);

        if (senhaCorreta)
            Console.WriteLine("✅ Senha verificada com sucesso!");
        else
            Console.WriteLine("❌ Senha incorreta!");
    }
}
