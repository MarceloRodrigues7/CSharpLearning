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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAdicionarDia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.dgDias = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDias)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.dgDias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDias.Location = new System.Drawing.Point(0, 24);
            this.dgDias.Name = "dgDias";
            this.dgDias.RowTemplate.Height = 25;
            this.dgDias.Size = new System.Drawing.Size(569, 196);
            this.dgDias.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 220);
            this.Controls.Add(this.dgDias);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Horas";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuTool;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdicionarDia;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSair;
        private System.Windows.Forms.DataGridView dgDias;
    }
}