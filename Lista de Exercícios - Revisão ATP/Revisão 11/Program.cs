using System;
using System.Runtime;
class Program
{
    // 11.	Faça um programa que mostre um menu de opções e calcule a área de um quadrado, de um retângulo, de um trapézio e de um círculo. Use funções para cada um desses cálculos. 
    static void Main(string[] args)
    {
        Console.Clear();
        int op = 0;
        Console.WriteLine("Informe qual cálculo deseja realizar.");
        do
        {
            ExibeMenu(ref op);
        } while (op != 0);
    }

    static void ExibeMenu(ref int op)
    {
        Console.Write("1 - Quadrado\n2 - Retângulo\n3 - Trapézio\n4 - Círculo\n-> ");
        op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                CalculaAreaQuadrado();
                break;
            case 2:
                CalculaAreaRetangulo();
                break;
            case 3:
                CalculaAreaTrapezio();
                break;
            case 4:
                CalculaAreaCirculo();
                break;
            default:
                break;
        }
    }

    static void CalculaAreaQuadrado()
    {
        Console.Clear();
        Console.Write("Informe o valor do lado (l) do quadrado: ");
        double lado = double.Parse(Console.ReadLine());
        Console.Clear();
        var area = lado * lado;
        Console.WriteLine($"Área do quadrado: {area}\n{lado} * {lado} = {area}");
    }
    static void CalculaAreaRetangulo()
    {
        Console.Clear();
        Console.Write("Informe o valor do lado 1 (l) do retângulo: ");
        double lado1 = double.Parse(Console.ReadLine());
        Console.Write("Informe o valor do lado 2 (l) do retângulo: ");
        double lado2 = double.Parse(Console.ReadLine());
        Console.Clear();
        var area = lado1 * lado2;
        Console.WriteLine($"Área do retângulo: {area}\n{lado1} * {lado2} = {area}");
    }
    static void CalculaAreaTrapezio()
    {
        Console.Clear();
        Console.Write("Informe o valor da base 1 (b) do trapézio: ");
        double base1 = double.Parse(Console.ReadLine());
        Console.Write("Informe o valor base 2 (b) do trapézio: ");
        double base2 = double.Parse(Console.ReadLine());
        Console.Write("Informe a altura (h) do trapézio: ");
        double altura = double.Parse(Console.ReadLine());
        Console.Clear();
        var area = (base1 + base2) * altura / 2;
        Console.WriteLine($"Área do trapézio: {area}\n({base1} + {base2}) * {altura} / 2 = {area}");
    }

    static void CalculaAreaCirculo()
    {
        Console.Clear();
        Console.Write("Informe o valor do raio (r) do círculo: ");
        double raio = double.Parse(Console.ReadLine());
        var area = Math.PI * (raio * raio);
        Console.WriteLine($"Área do círculo: {area}\n{Math.PI} * ({raio} * {raio}) = {area}");

    }
}