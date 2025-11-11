namespace WindowsFormsApp1
{
    partial class frmTab
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
            this.btnVoltartab = new System.Windows.Forms.Button();
            this.btnLimpartab = new System.Windows.Forms.Button();
            this.btnCalftab = new System.Windows.Forms.Button();
            this.btnCalfwtab = new System.Windows.Forms.Button();
            this.btnCalwtab = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtTab = new System.Windows.Forms.TextBox();
            this.lblTab = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltartab
            // 
            this.btnVoltartab.Location = new System.Drawing.Point(368, 385);
            this.btnVoltartab.Name = "btnVoltartab";
            this.btnVoltartab.Size = new System.Drawing.Size(75, 23);
            this.btnVoltartab.TabIndex = 35;
            this.btnVoltartab.Text = "voltar";
            this.btnVoltartab.UseVisualStyleBackColor = true;
            this.btnVoltartab.Click += new System.EventHandler(this.btnVoltartab_Click);
            // 
            // btnLimpartab
            // 
            this.btnLimpartab.Location = new System.Drawing.Point(175, 385);
            this.btnLimpartab.Name = "btnLimpartab";
            this.btnLimpartab.Size = new System.Drawing.Size(75, 23);
            this.btnLimpartab.TabIndex = 34;
            this.btnLimpartab.Text = "limpar";
            this.btnLimpartab.UseVisualStyleBackColor = true;
            this.btnLimpartab.Click += new System.EventHandler(this.btnLimpartab_Click);
            // 
            // btnCalftab
            // 
            this.btnCalftab.Location = new System.Drawing.Point(459, 325);
            this.btnCalftab.Name = "btnCalftab";
            this.btnCalftab.Size = new System.Drawing.Size(75, 23);
            this.btnCalftab.TabIndex = 33;
            this.btnCalftab.Text = "calfor";
            this.btnCalftab.UseVisualStyleBackColor = true;
            this.btnCalftab.Click += new System.EventHandler(this.btnCalftab_Click);
            // 
            // btnCalfwtab
            // 
            this.btnCalfwtab.Location = new System.Drawing.Point(277, 325);
            this.btnCalfwtab.Name = "btnCalfwtab";
            this.btnCalfwtab.Size = new System.Drawing.Size(75, 23);
            this.btnCalfwtab.TabIndex = 32;
            this.btnCalfwtab.Text = "cal fwille";
            this.btnCalfwtab.UseVisualStyleBackColor = true;
            this.btnCalfwtab.Click += new System.EventHandler(this.btnCalfwtab_Click);
            // 
            // btnCalwtab
            // 
            this.btnCalwtab.Location = new System.Drawing.Point(85, 326);
            this.btnCalwtab.Name = "btnCalwtab";
            this.btnCalwtab.Size = new System.Drawing.Size(75, 23);
            this.btnCalwtab.TabIndex = 31;
            this.btnCalwtab.Text = "cal Wille";
            this.btnCalwtab.UseVisualStyleBackColor = true;
            this.btnCalwtab.Click += new System.EventHandler(this.btnCalwtab_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(122, 42);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 28;
            // 
            // txtTab
            // 
            this.txtTab.Location = new System.Drawing.Point(122, 86);
            this.txtTab.Multiline = true;
            this.txtTab.Name = "txtTab";
            this.txtTab.ReadOnly = true;
            this.txtTab.Size = new System.Drawing.Size(100, 170);
            this.txtTab.TabIndex = 27;
            // 
            // lblTab
            // 
            this.lblTab.AutoSize = true;
            this.lblTab.Location = new System.Drawing.Point(54, 86);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(53, 13);
            this.lblTab.TabIndex = 26;
            this.lblTab.Text = "Tabuada:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(54, 42);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(47, 13);
            this.lblNum.TabIndex = 25;
            this.lblNum.Text = "Numero:";
            // 
            // frmTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltartab);
            this.Controls.Add(this.btnLimpartab);
            this.Controls.Add(this.btnCalftab);
            this.Controls.Add(this.btnCalfwtab);
            this.Controls.Add(this.btnCalwtab);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtTab);
            this.Controls.Add(this.lblTab);
            this.Controls.Add(this.lblNum);
            this.Name = "frmTab";
            this.Text = "Tabuada";
            this.Load += new System.EventHandler(this.frmTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltartab;
        private System.Windows.Forms.Button btnLimpartab;
        private System.Windows.Forms.Button btnCalftab;
        private System.Windows.Forms.Button btnCalfwtab;
        private System.Windows.Forms.Button btnCalwtab;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtTab;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.Label lblNum;
    }
}