using System;

public class Produto
{
    public string NomeProduto { get; set; } = string.Empty;
    public double PrecoCompra { get; set; }
    public double PrecoVenda { get; set; }
    public string Fabricante { get; set; } = string.Empty;
    public DateTime DataAquisicao { get; set; } = DateTime.Now;

    public Produto(string produto, double precoCompra, double precoVenda, string fabricante)
    {
        this.NomeProduto = produto;
        this.PrecoCompra = precoCompra;
        this.PrecoVenda = precoVenda;
        this.Fabricante = fabricante;
    }

    public static double CalculaLucro(double precoCompra, double precoVenda)
    {
        return precoVenda - precoCompra;
    }

}

public class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[2];

        for (int i = 0; i < produtos.Length; i++)
        {

            Console.Write("Informe o nome do produto: ");
            string? nomeProduto = Console.ReadLine();

            Console.Write("Informe o preço de compra: ");
            double precoCompra = double.Parse(Console.ReadLine()!);

            Console.Write("Informe o preço de venda: ");
            double precoVenda = double.Parse(Console.ReadLine()!);

            Console.Write("Infore o fabricante: ");
            string? fabricante = Console.ReadLine();

            produtos[i] = new(nomeProduto!, precoCompra, precoVenda, fabricante!);

        }

        Console.Write("Produtos com Lucro \n===================\n");

        foreach (var produto in produtos)
        {
            double lucro = Produto.CalculaLucro(produto.PrecoCompra, produto.PrecoVenda);

            if (lucro >= produto.PrecoCompra + produto.PrecoCompra * 0.5) Console.Write(produto.NomeProduto + " | Lucro: " + lucro);
        }
    }
}