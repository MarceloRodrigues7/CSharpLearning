namespace ControleHoras.UI
{
    partial class FrmAdicionaDia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraPausa = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraRetorno = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraFinal = new System.Windows.Forms.MaskedTextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora Pausa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora Retorno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora Final:";
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(99, 41);
            this.txtHoraInicio.Mask = "00:00";
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(39, 23);
            this.txtHoraInicio.TabIndex = 4;
            this.txtHoraInicio.Leave += new System.EventHandler(this.txtHoraInicio_Leave);
            // 
            // txtHoraPausa
            // 
            this.txtHoraPausa.Location = new System.Drawing.Point(216, 41);
            this.txtHoraPausa.Mask = "00:00";
            this.txtHoraPausa.Name = "txtHoraPausa";
            this.txtHoraPausa.Size = new System.Drawing.Size(39, 23);
            this.txtHoraPausa.TabIndex = 5;
            this.txtHoraPausa.Leave += new System.EventHandler(this.txtHoraPausa_Leave);
            // 
            // txtHoraRetorno
            // 
            this.txtHoraRetorno.Location = new System.Drawing.Point(99, 70);
            this.txtHoraRetorno.Mask = "00:00";
            this.txtHoraRetorno.Name = "txtHoraRetorno";
            this.txtHoraRetorno.Size = new System.Drawing.Size(39, 23);
            this.txtHoraRetorno.TabIndex = 6;
            this.txtHoraRetorno.Leave += new System.EventHandler(this.txtHoraRetorno_Leave);
            // 
            // txtHoraFinal
            // 
            this.txtHoraFinal.Location = new System.Drawing.Point(216, 70);
            this.txtHoraFinal.Mask = "00:00";
            this.txtHoraFinal.Name = "txtHoraFinal";
            this.txtHoraFinal.Size = new System.Drawing.Size(39, 23);
            this.txtHoraFinal.TabIndex = 7;
            this.txtHoraFinal.Leave += new System.EventHandler(this.txtHoraFinal_Leave);
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(99, 12);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(156, 23);
            this.dtData.TabIndex = 9;
            this.dtData.Leave += new System.EventHandler(this.dtData_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dia:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(99, 99);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(180, 99);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmAdicionaDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 128);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.txtHoraFinal);
            this.Controls.Add(this.txtHoraRetorno);
            this.Controls.Add(this.txtHoraPausa);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdicionaDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adiciona Dia";
            this.Load += new System.EventHandler(this.FrmAdicionaDia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtHoraInicio;
        private System.Windows.Forms.MaskedTextBox txtHoraPausa;
        private System.Windows.Forms.MaskedTextBox txtHoraRetorno;
        private System.Windows.Forms.MaskedTextBox txtHoraFinal;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
    }
}