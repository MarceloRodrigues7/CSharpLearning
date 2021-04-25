using Code_Gerator;
using Code_Gerator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Number_Generator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Valores v = new()
            {
                Minimo = numUpMinimo.Value,
                Maximo = numUpMaximo.Value
            };

            v = Valida_CheckNegativo(v);

            v = Gerator.Valida_Valores(v);

            Troca_Valores(v);

            int res = Gerator.Valor_Int(v.Minimo, v.Maximo);

            txtResultado.Text = Valid_CheckDecimal(res);
        }

        private string Valid_CheckDecimal(int res)
        {
            if (checkBoxNumeroDecimal.Checked == true)
            {
                byte resp = 1;
                return Gerator.Valida_Decimal(res, resp).ToString();
            }
            else
            {
                return res.ToString();
            }
        }

        private Valores Valida_CheckNegativo(Valores v)
        {
            byte resp = 0;
            if (checkBoxNumeroNegativo.Checked == true)
            {
                resp = 1;
            }
            v.Minimo = Gerator.Valida_Negativo(v.Minimo, resp);
            return v;
        }

        private void Troca_Valores(Valores v)
        {
            if (v.Trocado == 1)
            {
                numUpMinimo.Value = v.Minimo;
                numUpMaximo.Value = v.Maximo;
            }
        }
    }
}
