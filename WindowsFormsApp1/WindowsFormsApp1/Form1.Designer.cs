namespace WindowsFormsApp1
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiExe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTab = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGraus = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiArea = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExe,
            this.tsmiSair});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(800, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmiExe
            // 
            this.tsmiExe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTab,
            this.tsmiGraus,
            this.tsmiArea});
            this.tsmiExe.Name = "tsmiExe";
            this.tsmiExe.Size = new System.Drawing.Size(71, 20);
            this.tsmiExe.Text = "Exercicios";
            // 
            // tsmiSair
            // 
            this.tsmiSair.Name = "tsmiSair";
            this.tsmiSair.Size = new System.Drawing.Size(38, 20);
            this.tsmiSair.Text = "Sair";
            this.tsmiSair.Click += new System.EventHandler(this.tsmiSair_Click);
            // 
            // tsmiTab
            // 
            this.tsmiTab.Name = "tsmiTab";
            this.tsmiTab.Size = new System.Drawing.Size(180, 22);
            this.tsmiTab.Text = "Tabuada";
            this.tsmiTab.Click += new System.EventHandler(this.tsmiTab_Click);
            // 
            // tsmiGraus
            // 
            this.tsmiGraus.Name = "tsmiGraus";
            this.tsmiGraus.Size = new System.Drawing.Size(180, 22);
            this.tsmiGraus.Text = "Graus";
            this.tsmiGraus.Click += new System.EventHandler(this.tsmiGraus_Click);
            // 
            // tsmiArea
            // 
            this.tsmiArea.Name = "tsmiArea";
            this.tsmiArea.Size = new System.Drawing.Size(180, 22);
            this.tsmiArea.Text = "Área";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiExe;
        private System.Windows.Forms.ToolStripMenuItem tsmiTab;
        private System.Windows.Forms.ToolStripMenuItem tsmiSair;
        private System.Windows.Forms.ToolStripMenuItem tsmiGraus;
        private System.Windows.Forms.ToolStripMenuItem tsmiArea;
    }
}

