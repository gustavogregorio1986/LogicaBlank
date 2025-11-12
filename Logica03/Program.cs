using System;
using Logica03.Entidade;
using Logica03.Control;

namespace Logica03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.NomeProduto = "Notebook";
            produto.Descricao = "Notebook Dell Inspiron 15";
            produto.Preco = 3500.00m;
            produto.Quantidade = 10;

            Console.WriteLine("Nome do Produto: " + produto.NomeProduto);
            Console.WriteLine("Descirção: " + produto.Descricao);
            Console.WriteLine("Preço: " + produto.Preco);
            Console.WriteLine("Quantidade: " + produto.Quantidade);

            Console.WriteLine("----------------------------------------------------------------");

            Produto produto1 = new Produto();
            produto1.NomeProduto = "Celular";
            produto1.Descricao = "Celular android preto com camera profissional";
            produto1.Preco = 1100.00m;
            produto1.Quantidade = 3;

            Console.WriteLine("Nome do Produto: " + produto1.NomeProduto);
            Console.WriteLine("Descirção: " + produto1.Descricao);
            Console.WriteLine("Preço: " + produto1.Preco);
            Console.WriteLine("Quantidade: " + produto1.Quantidade);
        }
    }
}
