using ControleHoras.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleHoras.UI
{
    public partial class FrmMain : Form
    {
        private readonly EntityFactory _entityFactory;
        public FrmMain()
        {
            InitializeComponent();
            _entityFactory = new EntityFactory();
        }

        private void MenuItemSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemAdicionarDia_Click(object sender, EventArgs e)
        {
            FrmAdicionaDia frm = new(_entityFactory);
            frm.ShowDialog();
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            if (dgDias.Rows.Count > 0)
            {
                dgDias.DataSource = null;
            }
            var data = _entityFactory.Dias.OrderBy(d => d.Data).ToList();
            dgDias.DataSource = data;
            FormataGridView();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            TotalDeDias();
            TotalDeHoras();
            TotalsaldoHoras();
        }

        private void FormataGridView()
        {
            dgDias.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgDias.AllowUserToAddRows = false;
            dgDias.AllowUserToDeleteRows = false;
            dgDias.AllowUserToResizeRows = false;
            dgDias.AllowUserToOrderColumns = true;
            dgDias.ReadOnly = true;
            dgDias.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgDias.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgDias.Columns[0].Visible = false;
            dgDias.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDias.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDias.Columns[2].HeaderText = "Inicio";
            dgDias.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDias.Columns[3].HeaderText = "Pausa";
            dgDias.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDias.Columns[4].HeaderText = "Retorno";
            dgDias.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDias.Columns[5].HeaderText = "Final";
            dgDias.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgDias.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgDias.Columns[7].HeaderText = "Resultado";
        }

        private void TotalDeDias()
        {
            var dias = _entityFactory.Dias.Count();
            rodapeDiasTotal.Text = $"Total Dias: {dias}";
        }

        private void TotalDeHoras()
        {
            var totalHoras = new TimeSpan();
            var horas = _entityFactory.Dias.Select(d => d.TotalHoras);
            foreach (var hora in horas)
            {
                totalHoras += hora;
            }
            rodapeHorasTotal.Text = $"Total Horas: {totalHoras}";
        }

        private void TotalsaldoHoras()
        {
            var totalHoras = new TimeSpan();
            var dias = _entityFactory.Dias;
            foreach (var dia in dias)
            {
                totalHoras += dia.TotalHoras - TimeSpan.FromHours(8);
            }
            rodapeHorasSaldo.Text = $"Total Saldo Horas: {totalHoras}";
        }
    }
}
