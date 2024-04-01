using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe03
{
    internal class Aluno
    {
        public string Nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double soma()
        {
            double somatorio = nota1 + nota2 + nota3;
            return somatorio;
        }

        public bool situacao()
        {
            if (soma() >= 60) return true;
            else return false;

        }

        public double NotaRestante()
        {
            if (situacao()) return 0.0;
            else
            {
                return 60.0 - soma();
            }

        }

    }
}
