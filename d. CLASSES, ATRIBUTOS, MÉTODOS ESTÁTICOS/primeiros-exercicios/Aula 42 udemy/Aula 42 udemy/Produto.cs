using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_42_udemy
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtde;

        public double ValorTotalEmEstoque()
        {
            return Qtde * Preco;
        }

        public void AdicionarProdutos(int add)
        {
            Qtde = Qtde + add;
        }

        public void RemoverProdutos(int del)
        {
            Qtde = Qtde - del;
        }

    }
}
