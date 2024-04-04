/*Fazer um programa para ler os dados de N produtos (N fornecido pelo usuário). Ao final, mostrar a etiqueta de preço de
cada produto na mesma ordem em que foram digitados. Todo produto possui nome e preço. Produtos importados possuem uma 
taxa de alfândega, e produtos usados possuem data de fabricação. Estes dados específicos devem ser acrescentados na 
etiqueta de preço conforme exemplo (próxima página). Para produtos importados, a taxa e alfândega deve ser
acrescentada ao preço final do produto. Favor implementar o programa conforme projeto ao lado. */

using ExercicioPropostoUm.Entidades;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());

            List<Product> Produto = new List<Product>();

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Product #{i} data: ");

                Console.Write("Common, used or imported (c/u/i)? ");
                char Tipo = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string NomeProduto = Console.ReadLine();

                Console.Write("Price: ");
                double PrecoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto.Add(new(NomeProduto, PrecoProduto)); //comum 

                if (Tipo == 'c')
                {
                    Produto.Add(new Product(NomeProduto, PrecoProduto));
                }

                if (Tipo == 'i') //importado
                {
                    Console.Write("Customs fee: ");
                    double CustomsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Produto.Add(new ImportedProduct(NomeProduto, PrecoProduto, CustomsFee));
                }

                else if (Tipo == 'u') //usado
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    Produto.Add(new UsedProduct(NomeProduto, PrecoProduto, manufactureDate));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product obj in Produto)
            {
                Console.WriteLine(obj.priceTag());
            }
        }
    }
}