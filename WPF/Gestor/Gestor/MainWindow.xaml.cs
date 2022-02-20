using Gestor.Context;
using Gestor.UI;
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

namespace Gestor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EntityFactory _entityFactory;
        public MainWindow()
        {
            InitializeComponent();
            _entityFactory = new();
            ValidaContaExistente();

        }

        private void ValidaContaExistente()
        {
            var validaContaExistente = _entityFactory.Contas.Any();
            if (!validaContaExistente)
            {
                FrmIniciaGestor frm = new(_entityFactory);
                frm.ShowDialog();
                this.Close();
            }
            
        } 

        private void LimpaJanelaPrincipal()
        {
            if (JanelaPrincipal.Items.Count > 0)
            {
                JanelaPrincipal.Items.Clear();
            }
        }

        private void ChamaForm(object form, string titulo)
        {
            LimpaJanelaPrincipal();
            TabItem content = new();
            content.Content = form;
            content.Header = titulo;
            JanelaPrincipal.Items.Add(content);
            content.Focus();
        }

        private void MenuConta_Click(object sender, RoutedEventArgs e)
        {
            FrmConta child = new();
            ChamaForm(child.Content, "Conta");
        }

        private void MenuCategoria_Click(object sender, RoutedEventArgs e)
        {
            FrmCategorias child = new(_entityFactory);
            ChamaForm(child.Content, "Categorias");
        }

        private void MenuTipo_Click(object sender, RoutedEventArgs e)
        {
            FrmTipos child = new();
            ChamaForm(child.Content, "Tipos");
        }

        private void MenuStatus_Click(object sender, RoutedEventArgs e)
        {
            FrmStatus child = new();
            ChamaForm(child.Content, "Status");
        }

        private void MenuTransacao_Click(object sender, RoutedEventArgs e)
        {
            FrmTransacoes child = new();
            ChamaForm(child.Content, "Transacao");
        }
    }
}
