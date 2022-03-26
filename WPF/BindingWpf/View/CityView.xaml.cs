using BindingWpf.ViewModel;
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
using System.Windows.Shapes;

namespace BindingWpf.View
{
    /// <summary>
    /// Lógica interna para CityView.xaml
    /// </summary>
    public partial class CityView : Window
    {
        private PersonVM _vm = new();
        public CityView()
        {
            InitializeComponent();
            _vm.GetCities(_vm);

        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            _vm.Insert();
            txtName.Text = String.Empty;
            _vm.GetCities(_vm);
        }

        private void btnDeletar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            txtName.Text = String.Empty;
        }
    }
}
