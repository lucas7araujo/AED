using System;
class Program
{
    static void Main(string[] args)
    {
        int nPessoas = 3;
        char[] sexo = new char[nPessoas];
        int[] altura = new int[nPessoas];

        PreencheVetores(sexo, altura);
        System.Console.WriteLine($"Média de altura entre as mulheres (em cm): {RetornaMediaAlturaMulheres(sexo, altura)}");
        System.Console.WriteLine($"Número de homens: {RetornaNumeroDeHomens(sexo, altura)}");

    }

    static void PreencheVetores(char[] sexo, int[] altura)
    {
        for (int i = 0; i < sexo.Length; i++)
        {
            Console.Write($"Informe o sexo da pessoa {i + 1}: ");
            sexo[i] = char.ToUpper(char.Parse(Console.ReadLine()));

            while (sexo[i] != 'M' && sexo[i] != 'F')
            {
                Console.Write("Entrada Inválida, digite M ou F: ");
                sexo[i] = char.ToUpper(char.Parse(Console.ReadLine()));

            }

            Console.Write($"Informe a altura da pessoa {i + 1} (em cm): ");
            altura[i] = int.Parse(Console.ReadLine());
        }
    }

    static double RetornaMediaAlturaMulheres(char[] sexo, int[] altura)
    {
        double soma = 0;
        var cont = 0;

        for (int i = 0; i < sexo.Length; i++) if (sexo[i] == 'F') { soma += altura[i]; cont++; }

        if (soma == 0) return 0;

        return soma /= cont;
    }
    static int RetornaNumeroDeHomens(char[] sexo, int[] altura)
    {
        var cont = 0;

        for (int i = 0; i < sexo.Length; i++) if (sexo[i] == 'M') cont++;

        return cont;
    }

}