using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Conta
    {
        private int _agencia;
        private int _numeroConta;
        private decimal _saldo;

        public int Agencia
        {
            get { return _agencia; }
            private set
            {
                if (value > 0)
                    _agencia = value;
            }
        }
        public int NumeroConta { get => _numeroConta; set => _numeroConta = value; }
        public decimal Saldo { get => _saldo; set => _saldo = value; }

        public void SetAgencia(int agencia) => _agencia = agencia;
        public void Sacar(decimal valor) => _saldo -= valor;
        public void Depositar(decimal valor) => _saldo += valor;
    }
}
