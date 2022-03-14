using ControleHoras.Context;
using ControleHoras.Model;
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
    public partial class FrmAdicionaDia : Form
    {
        private readonly EntityFactory _entityFactory;
        private readonly List<DateTime> _listaDiasAdicionados;
        private TimeSpan _timespan;
        private Dia _dia;

        public FrmAdicionaDia(EntityFactory entityFactory)
        {
            InitializeComponent();
            _entityFactory = entityFactory;
            _listaDiasAdicionados = _entityFactory.Dias.Select(d => d.Data).ToList();
            _dia = new Dia();
        }

        private void FrmAdicionaDia_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _dia.Intervalo = Dia.CalculoIntervalor(_dia.HoraDois, _dia.HoraTres);
            _dia.TotalHoras = Dia.CalculoTotalHora(_dia.HoraUm, _dia.HoraQuatro, _dia.Intervalo);
            _entityFactory.Dias.Add(_dia);
            _entityFactory.SaveChanges();
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dtData.Value = new DateTime();
            txtHoraInicio.Text = string.Empty;
            txtHoraPausa.Text = string.Empty;
            txtHoraRetorno.Text = string.Empty;
            txtHoraFinal.Text = string.Empty;
            dtData.Focus();
        }

        private void dtData_Leave(object sender, EventArgs e)
        {
            if (_listaDiasAdicionados.Contains(dtData.Value))
            {
                dtData.Value = new DateTime();
                dtData.Focus();
            }
            else
            {
                _dia.Data = dtData.Value;
            }
        }

        private void txtHoraInicio_Leave(object sender, EventArgs e)
        {
            if (!TimeSpan.TryParse(txtHoraInicio.Text, out _timespan))
            {
                MessageBox.Show("Validar Horario Inicio");
                txtHoraInicio.Focus();
                txtHoraInicio.Text = string.Empty;
            }
            else
            {
                _dia.HoraUm = TimeSpan.Parse(txtHoraInicio.Text);
            }
        }

        private void txtHoraPausa_Leave(object sender, EventArgs e)
        {
            if (!TimeSpan.TryParse(txtHoraPausa.Text, out _timespan))
            {
                MessageBox.Show("Validar Horario Pausa");
                txtHoraPausa.Focus();
                txtHoraPausa.Text = string.Empty;
            }
            else
            {
                _dia.HoraDois = TimeSpan.Parse(txtHoraPausa.Text);
            }
        }

        private void txtHoraRetorno_Leave(object sender, EventArgs e)
        {
            if (!TimeSpan.TryParse(txtHoraRetorno.Text, out _timespan))
            {
                MessageBox.Show("Validar Horario Retorno");
                txtHoraRetorno.Focus();
                txtHoraRetorno.Text = string.Empty;
            }
            else
            {
                _dia.HoraTres = TimeSpan.Parse(txtHoraRetorno.Text);
            }
        }

        private void txtHoraFinal_Leave(object sender, EventArgs e)
        {
            if (!TimeSpan.TryParse(txtHoraFinal.Text, out _timespan))
            {
                MessageBox.Show("Validar Horario Final");
                txtHoraFinal.Focus();
                txtHoraFinal.Text = string.Empty;
            }
            else
            {
                _dia.HoraQuatro = TimeSpan.Parse(txtHoraFinal.Text);
            }
        }

        private void txtHoraInicio_TextChanged(object sender, EventArgs e)
        {
            if (txtHoraInicio.Text.Length == 5)
                txtHoraPausa.Focus();
        }

        private void txtHoraPausa_TextChanged(object sender, EventArgs e)
        {
            if (txtHoraPausa.Text.Length == 5)
                txtHoraRetorno.Focus();
        }

        private void txtHoraRetorno_TextChanged(object sender, EventArgs e)
        {
            if (txtHoraRetorno.Text.Length == 5)
                txtHoraFinal.Focus();
        }

        private void txtHoraFinal_TextChanged(object sender, EventArgs e)
        {
            if (txtHoraFinal.Text.Length == 5)
                btnSalvar.Focus();
        }
    }
}
