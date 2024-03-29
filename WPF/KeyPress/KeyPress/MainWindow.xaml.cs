﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KeyPress
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Calculo calculo;
        private readonly Conversao conversao;
        private decimal valorUm;
        private decimal valorDois;
        private EnumOperadores operador;
        private decimal resultadoCalculo;

        public MainWindow()
        {
            InitializeComponent();
            calculo = new();
            conversao = new();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            txtTeclaPressionada.Text = e.Key.ToString();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            var rValorUm = ArmazenaValorUm();
            var rValorDois = ArmazenaValorDois();
            var rOperador = ArmazenaValorOperador();
            if (rValorUm & rValorDois & rOperador)
            {
                resultadoCalculo = RealizaCalculo();
                txtRespCalculo.Text = resultadoCalculo.ToString();
            }
            ResetaParamentos();
        }

        private decimal RealizaCalculo()
        {
            switch (operador)
            {
                case EnumOperadores.Somar:
                    return calculo.Adicao(valorUm, valorDois);
                case EnumOperadores.Subtrair:
                    return calculo.Subtracao(valorUm, valorDois);
                case EnumOperadores.Multiplicar:
                    return calculo.Multiplicacao(valorUm, valorDois);
                case EnumOperadores.Dividir:
                    return calculo.Divisao(valorUm, valorDois);
                default:
                    return 0;
            }
        }

        private bool ArmazenaValorUm()
        {
            if (!conversao.ValidaTextoDecimal(txtValorUm.Text))
            {
                MessageBox.Show("Valor 1 deve ter apenas numeros");
                txtValorUm.Focus();
                return false;
            }
            valorUm = conversao.ConverteTextoParaDecimal(txtValorUm.Text);
            return true;
        }

        private bool ArmazenaValorDois()
        {
            if (!conversao.ValidaTextoDecimal(txtValorDois.Text))
            {
                MessageBox.Show("Valor 2 deve ter apenas numeros");
                txtValorDois.Focus();
                return false;
            }
            valorDois = conversao.ConverteTextoParaDecimal(txtValorDois.Text);
            return true;
        }

        private bool ArmazenaValorOperador()
        {
            operador = conversao.ConverteTextoParaOperador(txtOperador.Text);
            if (operador == EnumOperadores.Erro)
            {
                MessageBox.Show("Operador invalido - Corretos: +, -, * ou /");
                txtOperador.Focus();
                return false;
            }
            return true;
        }

        private void ResetaParamentos()
        {
            valorUm = 0;
            valorDois = 0;
            resultadoCalculo = 0;
        }
    }
}
