
namespace Random_Number_Generator
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpMinimo = new System.Windows.Forms.NumericUpDown();
            this.numUpMaximo = new System.Windows.Forms.NumericUpDown();
            this.checkBoxNumeroNegativo = new System.Windows.Forms.CheckBox();
            this.checkBoxNumeroDecimal = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpMaximo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Máxima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Mínimo";
            // 
            // numUpMinimo
            // 
            this.numUpMinimo.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpMinimo.Location = new System.Drawing.Point(119, 42);
            this.numUpMinimo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numUpMinimo.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.numUpMinimo.Name = "numUpMinimo";
            this.numUpMinimo.Size = new System.Drawing.Size(96, 20);
            this.numUpMinimo.TabIndex = 2;
            // 
            // numUpMaximo
            // 
            this.numUpMaximo.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpMaximo.Location = new System.Drawing.Point(119, 73);
            this.numUpMaximo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numUpMaximo.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.numUpMaximo.Name = "numUpMaximo";
            this.numUpMaximo.Size = new System.Drawing.Size(96, 20);
            this.numUpMaximo.TabIndex = 3;
            // 
            // checkBoxNumeroNegativo
            // 
            this.checkBoxNumeroNegativo.AutoSize = true;
            this.checkBoxNumeroNegativo.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxNumeroNegativo.Location = new System.Drawing.Point(240, 57);
            this.checkBoxNumeroNegativo.Name = "checkBoxNumeroNegativo";
            this.checkBoxNumeroNegativo.Size = new System.Drawing.Size(146, 17);
            this.checkBoxNumeroNegativo.TabIndex = 4;
            this.checkBoxNumeroNegativo.Text = "Número Negativo";
            this.checkBoxNumeroNegativo.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumeroDecimal
            // 
            this.checkBoxNumeroDecimal.AutoSize = true;
            this.checkBoxNumeroDecimal.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxNumeroDecimal.Location = new System.Drawing.Point(240, 80);
            this.checkBoxNumeroDecimal.Name = "checkBoxNumeroDecimal";
            this.checkBoxNumeroDecimal.Size = new System.Drawing.Size(138, 17);
            this.checkBoxNumeroDecimal.TabIndex = 5;
            this.checkBoxNumeroDecimal.Text = "Número Decimal";
            this.checkBoxNumeroDecimal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gerador de Número Aleatorio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 29);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(237, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opções";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(12, 112);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(68, 23);
            this.btnGerar.TabIndex = 9;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(86, 112);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(88, 23);
            this.txtResultado.TabIndex = 10;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 147);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxNumeroDecimal);
            this.Controls.Add(this.checkBoxNumeroNegativo);
            this.Controls.Add(this.numUpMaximo);
            this.Controls.Add(this.numUpMinimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador";
            ((System.ComponentModel.ISupportInitialize)(this.numUpMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpMaximo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpMinimo;
        private System.Windows.Forms.NumericUpDown numUpMaximo;
        private System.Windows.Forms.CheckBox checkBoxNumeroNegativo;
        private System.Windows.Forms.CheckBox checkBoxNumeroDecimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

