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
            this.txtGraus = new System.Windows.Forms.TextBox();
            this.lblGraus = new System.Windows.Forms.Label();
            this.btnVoltargraus = new System.Windows.Forms.Button();
            this.btnLimpargraus = new System.Windows.Forms.Button();
            this.btnCalfgraus = new System.Windows.Forms.Button();
            this.btnCalfwgraus = new System.Windows.Forms.Button();
            this.btnCalwgraus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGraus
            // 
            this.txtGraus.Location = new System.Drawing.Point(186, 41);
            this.txtGraus.Multiline = true;
            this.txtGraus.Name = "txtGraus";
            this.txtGraus.ReadOnly = true;
            this.txtGraus.Size = new System.Drawing.Size(100, 169);
            this.txtGraus.TabIndex = 12;
            // 
            // lblGraus
            // 
            this.lblGraus.AutoSize = true;
            this.lblGraus.Location = new System.Drawing.Point(71, 41);
            this.lblGraus.Name = "lblGraus";
            this.lblGraus.Size = new System.Drawing.Size(50, 13);
            this.lblGraus.TabIndex = 9;
            this.lblGraus.Text = "F para C:";
            // 
            // btnVoltargraus
            // 
            this.btnVoltargraus.Location = new System.Drawing.Point(342, 371);
            this.btnVoltargraus.Name = "btnVoltargraus";
            this.btnVoltargraus.Size = new System.Drawing.Size(75, 23);
            this.btnVoltargraus.TabIndex = 40;
            this.btnVoltargraus.Text = "voltar";
            this.btnVoltargraus.UseVisualStyleBackColor = true;
            // 
            // btnLimpargraus
            // 
            this.btnLimpargraus.Location = new System.Drawing.Point(149, 371);
            this.btnLimpargraus.Name = "btnLimpargraus";
            this.btnLimpargraus.Size = new System.Drawing.Size(75, 23);
            this.btnLimpargraus.TabIndex = 39;
            this.btnLimpargraus.Text = "limpar";
            this.btnLimpargraus.UseVisualStyleBackColor = true;
            // 
            // btnCalfgraus
            // 
            this.btnCalfgraus.Location = new System.Drawing.Point(433, 311);
            this.btnCalfgraus.Name = "btnCalfgraus";
            this.btnCalfgraus.Size = new System.Drawing.Size(75, 23);
            this.btnCalfgraus.TabIndex = 38;
            this.btnCalfgraus.Text = "calfor";
            this.btnCalfgraus.UseVisualStyleBackColor = true;
            // 
            // btnCalfwgraus
            // 
            this.btnCalfwgraus.Location = new System.Drawing.Point(251, 311);
            this.btnCalfwgraus.Name = "btnCalfwgraus";
            this.btnCalfwgraus.Size = new System.Drawing.Size(75, 23);
            this.btnCalfwgraus.TabIndex = 37;
            this.btnCalfwgraus.Text = "cal fwille";
            this.btnCalfwgraus.UseVisualStyleBackColor = true;
            // 
            // btnCalwgraus
            // 
            this.btnCalwgraus.Location = new System.Drawing.Point(59, 312);
            this.btnCalwgraus.Name = "btnCalwgraus";
            this.btnCalwgraus.Size = new System.Drawing.Size(75, 23);
            this.btnCalwgraus.TabIndex = 36;
            this.btnCalwgraus.Text = "cal Wille";
            this.btnCalwgraus.UseVisualStyleBackColor = true;
            // 
            // frmGraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltargraus);
            this.Controls.Add(this.btnLimpargraus);
            this.Controls.Add(this.btnCalfgraus);
            this.Controls.Add(this.btnCalfwgraus);
            this.Controls.Add(this.btnCalwgraus);
            this.Controls.Add(this.txtGraus);
            this.Controls.Add(this.lblGraus);
            this.Name = "frmGraus";
            this.Text = "Graus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGraus;
        private System.Windows.Forms.Label lblGraus;
        private System.Windows.Forms.Button btnVoltargraus;
        private System.Windows.Forms.Button btnLimpargraus;
        private System.Windows.Forms.Button btnCalfgraus;
        private System.Windows.Forms.Button btnCalfwgraus;
        private System.Windows.Forms.Button btnCalwgraus;
    }
}