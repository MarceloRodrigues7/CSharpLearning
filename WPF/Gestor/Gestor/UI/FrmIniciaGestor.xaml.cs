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
    /// Lógica interna para FrmIniciaGestor.xaml
    /// </summary>
    public partial class FrmIniciaGestor : Window
    {
        private readonly EntityFactory _entityFactory;
        private Conta _conta = new();
        public FrmIniciaGestor(EntityFactory entityFactory)
        {
            InitializeComponent();
            _entityFactory = entityFactory;
            this.ResizeMode = System.Windows.ResizeMode.NoResize;
        }

        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            var conta = _conta.CriaConta(decimal.Parse(txtSaldo.Text));
            _entityFactory.Contas.Add(conta);
            _entityFactory.SaveChanges();
            ChamaMainForm();
        }

        private void ChamaMainForm()
        {
            this.Close();
            MainWindow frm = new();
            frm.Show();
        }
    }
}
