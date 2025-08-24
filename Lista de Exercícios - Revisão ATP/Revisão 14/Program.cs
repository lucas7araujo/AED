using System;
using System.Collections.Generic;
using System.Linq;

// 14.	Faça um programa que receba o nome de um produto, a quantidade e o preço de 10 produtos. Mostre o valor do inventário do estoque (total de produtos e valor total em estoque de cada produto).
Console.Clear();
for (int i = 0; i < 2; i++)
{
    var nome = "";
    double preco = 0;
    var quantidade = 0;

    Console.Write("Insira o nome do Produto: ");
    nome = Console.ReadLine();
    Console.Write($"Insira a quantidade de {nome} no estoque: ");
    quantidade = int.Parse(Console.ReadLine());
    Console.Write($"Insira o preço de {nome}: ");
    preco = double.Parse(Console.ReadLine());
    Console.Clear();
    Produto p = new(nome, preco, quantidade);
    Produto.AdicionaProdutoNaLista(p);
}

Console.Clear();
Produto.ExibeInformacoes();
Console.ReadKey();
Console.Clear();
