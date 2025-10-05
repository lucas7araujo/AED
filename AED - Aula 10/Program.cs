using System;
using BCrypt.Net;

class Program
{
    static void Main()
    {
        Console.Write("Digite a senha: ");
        string senha = Console.ReadLine();

        // Gerando hash com work factor 12
        string hash = BCrypt.Net.BCrypt.HashPassword(senha, workFactor: 12);

        Console.WriteLine($"Hash gerado: {hash}");

        // Verificação da senha
        Console.Write("Digite a senha novamente para verificar: ");
        string senhaVerifica = Console.ReadLine();

        string senhaNova = BCryptDecrypt(hash);

        bool confere = BCrypt.Net.BCrypt.Verify(senhaVerifica, hash);

        Console.WriteLine(confere ? "Senha correta" : "Senha incorreta");
    }
}
