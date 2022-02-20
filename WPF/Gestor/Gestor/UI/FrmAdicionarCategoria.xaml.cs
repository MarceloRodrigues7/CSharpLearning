using Gestor.Context;
using Gestor.Model;
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
    /// Lógica interna para FrmAdicionarCategoria.xaml
    /// </summary>
    public partial class FrmAdicionarCategoria : Window
    {
        private readonly EntityFactory _entityFactory;

        public FrmAdicionarCategoria(EntityFactory entityFactory)
        {
            InitializeComponent();
            _entityFactory = entityFactory;
            CarregaCombobox();
        }

        private void LimpaCampos()
        {
            txtDescricao.Text = String.Empty;
            cbRegra.Text = String.Empty;
            CarregaCombobox();
        }

        private void CarregaCombobox()
        {
            if (cbRegra.Items.Count > 0)
            {
                cbRegra.Items.Clear();
            }
            cbRegra.ItemsSource = Enum.GetValues(typeof(RegraCategoria));
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            LimpaCampos();
            txtDescricao.Focus();
        }

        private void btnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            var categoria = new Categoria().CriaObj(txtDescricao.Text, cbRegra.SelectedItem);
            _entityFactory.Categorias.Add(categoria);
            _entityFactory.SaveChanges();
            this.Close();
        }

    }
}
