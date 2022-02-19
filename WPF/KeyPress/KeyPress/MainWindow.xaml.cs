using System;
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

    }
}
