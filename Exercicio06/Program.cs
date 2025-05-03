using System;
using System.Globalization;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public double ValorTotalEstoque()
    {
        return Preco * Quantidade;
    }
}

class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nCadastro do Produto {i + 1}:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            produtos[i] = new Produto { Nome = nome, Preco = preco, Quantidade = quantidade };
        }

        Console.WriteLine("\nProdutos cadastrados e seus valores totais em estoque:");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"{produto.Nome} - Total em estoque: R$ {produto.ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

