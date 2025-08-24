using System;
using System.Collections.Generic;
using System.Linq;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome, double preco, int quantidade)
    {
        this.Nome = nome;
        this.Preco = preco;
        this.Quantidade = quantidade;
    }
    private static readonly List<Produto> Produtos = new List<Produto>();
    public double RetornaValorEstoquePorProduto() => Preco * Quantidade;
    public static void AdicionaProdutoNaLista(Produto p) => Produtos.Add(p);
    public static double RetornaValorTotalEstoque() =>
        Produtos.Sum(p => p.RetornaValorEstoquePorProduto());
    public override string ToString() =>
        $"Produto: {Nome}, Preço: {Preco:C}, Quantidade: {Quantidade}, Valor Estoque: {RetornaValorEstoquePorProduto():C}";

    public static void ExibeInformacoes()
    {
        foreach (var produto in Produtos)
        {
            System.Console.WriteLine(produto);
        }

        Console.WriteLine($"\nValor total do inventário: {RetornaValorTotalEstoque} ");
    }
}
