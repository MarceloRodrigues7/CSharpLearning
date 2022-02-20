using Gestor.Context;
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

namespace Gestor.UI
{
    /// <summary>
    /// Lógica interna para FrmCategorias.xaml
    /// </summary>
    public partial class FrmCategorias : Window
    {
        private readonly EntityFactory _entityFactory;
        public FrmCategorias(EntityFactory entityFactory)
        {
            InitializeComponent();
            _entityFactory = entityFactory;
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            var data = _entityFactory.Categorias.ToList();
            dtCategorias.ItemsSource = data;
        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            FrmAdicionarCategoria frm = new(_entityFactory);
            frm.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            CarregaGrid();
        }
    }
}
