using System;
using System.Globalization;

namespace Course
{
    class ConversorDeMoeda
    {
        
        public static double conversao(double cotacao, double qtde)
        {
            double valor = qtde * cotacao;
            double iof = valor * 1.06;
            return iof;
        }

    }
}
