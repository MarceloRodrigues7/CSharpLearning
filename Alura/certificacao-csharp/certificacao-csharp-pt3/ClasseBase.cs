using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_pt3
{
    public class ClasseBase
    {
        static void Teste()
        {
            Funcionario funcionario = new Funcionario(1500);
            funcionario.CPF = "123.456.789-00";
            funcionario.Nome = "José da silva";
            funcionario.DataNascimento = new DateTime(2000, 1, 1);

            ((IFuncionario)funcionario).CargaHorariaMensal = 168;
            ((IPlantonista)funcionario).CargaHorariaMensal = 32;
            funcionario.EfetuarPagamento();
            funcionario.CrachaGerado += (s, e) =>
            {
                Console.WriteLine("Crachá gerado");
            };
            ((IFuncionario)funcionario).GerarCracha();
            ((IPlantonista)funcionario).GerarCracha();

            Cliente cliente = new Cliente
            {
                CPF = "789.456.123-99",
                DataNascimento = new DateTime(1980, 1, 1),
                Nome = "Maria de Souza",
                DataUltimaCompra = new DateTime(2018, 1, 1),
                ValorUltimaCompra = 200
            };

            Console.WriteLine(cliente);

            Console.ReadKey();
        }
        interface IFuncionario
        {
            string CPF { get; set; }
            string Nome { get; set; }
            DateTime DataNascimento { get; set; }

            event EventHandler CrachaGerado;

            void GerarCracha();
            decimal Salario { get; }
            int CargaHorariaMensal { get; set; }
            void EfetuarPagamento();
        }

        interface IPlantonista
        {
            int CargaHorariaMensal { get; set; }
            void GerarCracha();
        }

        internal class Funcionario : Pessoa, IFuncionario, IPlantonista
        {
            public decimal Salario { get; }

            public event EventHandler CrachaGerado;

            void IFuncionario.GerarCracha()
            {
                throw new NotImplementedException();
            }
            void IPlantonista.GerarCracha()
            {
                throw new NotImplementedException();
            }

            int IFuncionario.CargaHorariaMensal { get; set; }
            int IPlantonista.CargaHorariaMensal { get; set; }

            public Funcionario(decimal salario)
            {
                this.Salario = salario;
            }

            public void EfetuarPagamento()
            {
                throw new NotImplementedException();
            }


        }

        internal class Cliente : Pessoa
        {
            public DateTime? DataUltimaCompra { get; set; }
            public decimal? ValorUltimaCompra { get; set; }

            public override string ToString()
            {
                return $"Nome:{Nome}, Data Última Compra:{DataUltimaCompra}";
            }
        }

        abstract internal class Pessoa
        {
            public string CPF { get; set; }
            public string Nome { get; set; }
            public DateTime DataNascimento { get; set; }
        }
    }
}
