using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensao
{
    internal class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Quarto(string nome, string email) { Nome = nome; Email = email; }

    }
}
