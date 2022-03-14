namespace ControleHoras.UI
{
    partial class FrmMain
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
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.MenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAdicionarDia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.dgDias = new System.Windows.Forms.DataGridView();
            this.PainelRodape = new System.Windows.Forms.StatusStrip();
            this.rodapeHorasTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.rodapeDiasTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.rodapeHorasSaldo = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDias)).BeginInit();
            this.PainelRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMain
            // 
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTool});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(587, 24);
            this.MenuMain.TabIndex = 0;
            this.MenuMain.Text = "menuStrip1";
            // 
            // MenuTool
            // 
            this.MenuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAdicionarDia,
            this.toolStripMenuItem1,
            this.MenuItemSair});
            this.MenuTool.Name = "MenuTool";
            this.MenuTool.Size = new System.Drawing.Size(50, 20);
            this.MenuTool.Text = "Menu";
            // 
            // MenuItemAdicionarDia
            // 
            this.MenuItemAdicionarDia.Name = "MenuItemAdicionarDia";
            this.MenuItemAdicionarDia.Size = new System.Drawing.Size(145, 22);
            this.MenuItemAdicionarDia.Text = "Adicionar Dia";
            this.MenuItemAdicionarDia.Click += new System.EventHandler(this.MenuItemAdicionarDia_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 6);
            // 
            // MenuItemSair
            // 
            this.MenuItemSair.Name = "MenuItemSair";
            this.MenuItemSair.Size = new System.Drawing.Size(145, 22);
            this.MenuItemSair.Text = "Sair";
            this.MenuItemSair.Click += new System.EventHandler(this.MenuItemSair_Click);
            // 
            // dgDias
            // 
            this.dgDias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDias.Location = new System.Drawing.Point(0, 83);
            this.dgDias.Name = "dgDias";
            this.dgDias.RowTemplate.Height = 25;
            this.dgDias.Size = new System.Drawing.Size(587, 273);
            this.dgDias.TabIndex = 3;
            // 
            // PainelRodape
            // 
            this.PainelRodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rodapeHorasTotal,
            this.rodapeDiasTotal,
            this.rodapeHorasSaldo});
            this.PainelRodape.Location = new System.Drawing.Point(0, 359);
            this.PainelRodape.Name = "PainelRodape";
            this.PainelRodape.Size = new System.Drawing.Size(587, 22);
            this.PainelRodape.TabIndex = 2;
            this.PainelRodape.Text = "statusStrip1";
            // 
            // rodapeHorasTotal
            // 
            this.rodapeHorasTotal.Name = "rodapeHorasTotal";
            this.rodapeHorasTotal.Size = new System.Drawing.Size(100, 17);
            this.rodapeHorasTotal.Text = "rodapeHorasTotal";
            // 
            // rodapeDiasTotal
            // 
            this.rodapeDiasTotal.Name = "rodapeDiasTotal";
            this.rodapeDiasTotal.Size = new System.Drawing.Size(91, 17);
            this.rodapeDiasTotal.Text = "rodapeDiasTotal";
            // 
            // rodapeHorasSaldo
            // 
            this.rodapeHorasSaldo.Name = "rodapeHorasSaldo";
            this.rodapeHorasSaldo.Size = new System.Drawing.Size(104, 17);
            this.rodapeHorasSaldo.Text = "rodapeHorasSaldo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 53);
            this.panel1.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PainelRodape);
            this.Controls.Add(this.dgDias);
            this.Controls.Add(this.MenuMain);
            this.MainMenuStrip = this.MenuMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Horas";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDias)).EndInit();
            this.PainelRodape.ResumeLayout(false);
            this.PainelRodape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem MenuTool;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdicionarDia;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSair;
        private System.Windows.Forms.DataGridView dgDias;
        private System.Windows.Forms.StatusStrip PainelRodape;
        private System.Windows.Forms.ToolStripStatusLabel rodapeHorasTotal;
        private System.Windows.Forms.ToolStripStatusLabel rodapeDiasTotal;
        private System.Windows.Forms.ToolStripStatusLabel rodapeHorasSaldo;
        private System.Windows.Forms.Panel panel1;
    }
}