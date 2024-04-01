using Aula_42_udemy;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            produto.Qtde = int.Parse(Console.ReadLine());

            double estoque = produto.ValorTotalEmEstoque();

            Console.WriteLine(" ");

            Console.WriteLine("Dados do produto: {0}, $ {1}, {2} unidades, Total: $ {3}", produto.Nome, produto.Preco.ToString("F2", CultureInfo.InvariantCulture), produto.Qtde, estoque);

            Console.WriteLine(" ");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");

            int adicionar = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(adicionar);

            Console.WriteLine(" ");

            double estoque_update = produto.ValorTotalEmEstoque();

            Console.WriteLine("Dados atualizados: {0}, $ {1:F2}, {2} unidades, Total: $ {3}", produto.Nome, produto.Preco.ToString("F2", CultureInfo.InvariantCulture), produto.Qtde, estoque_update);

            Console.WriteLine(" ");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int remover = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(remover);

            double estoque_update2 = produto.ValorTotalEmEstoque();
            Console.WriteLine(" ");

            Console.WriteLine("Dados atualizados: {0}, $ {1:F2}, {2} unidades, Total: $ {3}", produto.Nome, produto.Preco.ToString("F2", CultureInfo.InvariantCulture), produto.Qtde, estoque_update2);



        }
    }
}
