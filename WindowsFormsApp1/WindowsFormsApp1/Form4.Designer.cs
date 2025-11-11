namespace WindowsFormsApp1
{
    partial class frmGraus
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
            this.lblGrausf = new System.Windows.Forms.Label();
            this.btnVoltargraus = new System.Windows.Forms.Button();
            this.btnLimpargraus = new System.Windows.Forms.Button();
            this.btnCalfgraus = new System.Windows.Forms.Button();
            this.btnCalfwgraus = new System.Windows.Forms.Button();
            this.btnCalwgraus = new System.Windows.Forms.Button();
            this.lblGrausc = new System.Windows.Forms.Label();
            this.txtGrausf = new System.Windows.Forms.TextBox();
            this.txtGrausc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGrausf
            // 
            this.lblGrausf.AutoSize = true;
            this.lblGrausf.Location = new System.Drawing.Point(237, 49);
            this.lblGrausf.Name = "lblGrausf";
            this.lblGrausf.Size = new System.Drawing.Size(19, 13);
            this.lblGrausf.TabIndex = 9;
            this.lblGrausf.Text = "F :";
            // 
            // btnVoltargraus
            // 
            this.btnVoltargraus.Location = new System.Drawing.Point(342, 371);
            this.btnVoltargraus.Name = "btnVoltargraus";
            this.btnVoltargraus.Size = new System.Drawing.Size(75, 23);
            this.btnVoltargraus.TabIndex = 40;
            this.btnVoltargraus.Text = "voltar";
            this.btnVoltargraus.UseVisualStyleBackColor = true;
            this.btnVoltargraus.Click += new System.EventHandler(this.btnVoltargraus_Click);
            // 
            // btnLimpargraus
            // 
            this.btnLimpargraus.Location = new System.Drawing.Point(149, 371);
            this.btnLimpargraus.Name = "btnLimpargraus";
            this.btnLimpargraus.Size = new System.Drawing.Size(75, 23);
            this.btnLimpargraus.TabIndex = 39;
            this.btnLimpargraus.Text = "limpar";
            this.btnLimpargraus.UseVisualStyleBackColor = true;
            this.btnLimpargraus.Click += new System.EventHandler(this.btnLimpargraus_Click);
            // 
            // btnCalfgraus
            // 
            this.btnCalfgraus.Location = new System.Drawing.Point(433, 311);
            this.btnCalfgraus.Name = "btnCalfgraus";
            this.btnCalfgraus.Size = new System.Drawing.Size(75, 23);
            this.btnCalfgraus.TabIndex = 38;
            this.btnCalfgraus.Text = "calfor";
            this.btnCalfgraus.UseVisualStyleBackColor = true;
            this.btnCalfgraus.Click += new System.EventHandler(this.btnCalfgraus_Click);
            // 
            // btnCalfwgraus
            // 
            this.btnCalfwgraus.Location = new System.Drawing.Point(251, 311);
            this.btnCalfwgraus.Name = "btnCalfwgraus";
            this.btnCalfwgraus.Size = new System.Drawing.Size(75, 23);
            this.btnCalfwgraus.TabIndex = 37;
            this.btnCalfwgraus.Text = "cal fwille";
            this.btnCalfwgraus.UseVisualStyleBackColor = true;
            this.btnCalfwgraus.Click += new System.EventHandler(this.btnCalfwgraus_Click);
            // 
            // btnCalwgraus
            // 
            this.btnCalwgraus.Location = new System.Drawing.Point(59, 312);
            this.btnCalwgraus.Name = "btnCalwgraus";
            this.btnCalwgraus.Size = new System.Drawing.Size(75, 23);
            this.btnCalwgraus.TabIndex = 36;
            this.btnCalwgraus.Text = "cal Wille";
            this.btnCalwgraus.UseVisualStyleBackColor = true;
            this.btnCalwgraus.Click += new System.EventHandler(this.btnCalwgraus_Click);
            // 
            // lblGrausc
            // 
            this.lblGrausc.AutoSize = true;
            this.lblGrausc.Location = new System.Drawing.Point(45, 49);
            this.lblGrausc.Name = "lblGrausc";
            this.lblGrausc.Size = new System.Drawing.Size(17, 13);
            this.lblGrausc.TabIndex = 41;
            this.lblGrausc.Text = "C:";
            // 
            // txtGrausf
            // 
            this.txtGrausf.Location = new System.Drawing.Point(262, 46);
            this.txtGrausf.Multiline = true;
            this.txtGrausf.Name = "txtGrausf";
            this.txtGrausf.ReadOnly = true;
            this.txtGrausf.Size = new System.Drawing.Size(28, 230);
            this.txtGrausf.TabIndex = 42;
            // 
            // txtGrausc
            // 
            this.txtGrausc.Location = new System.Drawing.Point(91, 49);
            this.txtGrausc.Multiline = true;
            this.txtGrausc.Name = "txtGrausc";
            this.txtGrausc.ReadOnly = true;
            this.txtGrausc.Size = new System.Drawing.Size(31, 230);
            this.txtGrausc.TabIndex = 43;
            // 
            // frmGraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGrausc);
            this.Controls.Add(this.txtGrausf);
            this.Controls.Add(this.lblGrausc);
            this.Controls.Add(this.btnVoltargraus);
            this.Controls.Add(this.btnLimpargraus);
            this.Controls.Add(this.btnCalfgraus);
            this.Controls.Add(this.btnCalfwgraus);
            this.Controls.Add(this.btnCalwgraus);
            this.Controls.Add(this.lblGrausf);
            this.Name = "frmGraus";
            this.Text = "Graus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGrausf;
        private System.Windows.Forms.Button btnVoltargraus;
        private System.Windows.Forms.Button btnLimpargraus;
        private System.Windows.Forms.Button btnCalfgraus;
        private System.Windows.Forms.Button btnCalfwgraus;
        private System.Windows.Forms.Button btnCalwgraus;
        private System.Windows.Forms.Label lblGrausc;
        private System.Windows.Forms.TextBox txtGrausf;
        private System.Windows.Forms.TextBox txtGrausc;
    }
}