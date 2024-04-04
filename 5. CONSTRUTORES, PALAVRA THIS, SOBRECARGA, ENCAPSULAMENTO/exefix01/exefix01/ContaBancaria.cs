using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    internal class ContaBancaria
    {
        private string _nome;
        private int _nroDaConta = 0;
        private double _saldo = 0.0;

        public int NroDaConta
        {

            get { return _nroDaConta; }
            set
            {
                if (_nroDaConta == 0)
                {
                    _nroDaConta = value;
                }
            }
        }

        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (_saldo == 0.0)
                    _saldo = value;
            }
        }

        public double Deposito
        {
            set { _saldo = _saldo + value; }
        }

        public double Saque
        {
            set { _saldo = _saldo - (value + 5); }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public override string ToString()
        {
            return "\nConta " + _nroDaConta + ", Titular: " + _nome + ", Saldo: $ " + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
