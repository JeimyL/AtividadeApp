namespace WindowsFormsApp1
{
    partial class frmArea
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
            this.txtQtdcom = new System.Windows.Forms.TextBox();
            this.txtAcom = new System.Windows.Forms.TextBox();
            this.lblAcom = new System.Windows.Forms.Label();
            this.lblQtdcom = new System.Windows.Forms.Label();
            this.txtAres = new System.Windows.Forms.TextBox();
            this.lblAres = new System.Windows.Forms.Label();
            this.btnVoltararea = new System.Windows.Forms.Button();
            this.btnLimpararea = new System.Windows.Forms.Button();
            this.txtLargcom = new System.Windows.Forms.TextBox();
            this.txtCompcom = new System.Windows.Forms.TextBox();
            this.lblLargcom = new System.Windows.Forms.Label();
            this.lblCompcom = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQtdcom
            // 
            this.txtQtdcom.Location = new System.Drawing.Point(277, 48);
            this.txtQtdcom.Name = "txtQtdcom";
            this.txtQtdcom.Size = new System.Drawing.Size(100, 20);
            this.txtQtdcom.TabIndex = 12;
            // 
            // txtAcom
            // 
            this.txtAcom.Location = new System.Drawing.Point(577, 48);
            this.txtAcom.Multiline = true;
            this.txtAcom.Name = "txtAcom";
            this.txtAcom.ReadOnly = true;
            this.txtAcom.Size = new System.Drawing.Size(100, 22);
            this.txtAcom.TabIndex = 11;
            // 
            // lblAcom
            // 
            this.lblAcom.AutoSize = true;
            this.lblAcom.Location = new System.Drawing.Point(455, 55);
            this.lblAcom.Name = "lblAcom";
            this.lblAcom.Size = new System.Drawing.Size(98, 13);
            this.lblAcom.TabIndex = 10;
            this.lblAcom.Text = "Area dos comodos:";
            // 
            // lblQtdcom
            // 
            this.lblQtdcom.AutoSize = true;
            this.lblQtdcom.Location = new System.Drawing.Point(88, 48);
            this.lblQtdcom.Name = "lblQtdcom";
            this.lblQtdcom.Size = new System.Drawing.Size(126, 13);
            this.lblQtdcom.TabIndex = 9;
            this.lblQtdcom.Text = "Quantidade de comodos:";
            // 
            // txtAres
            // 
            this.txtAres.Location = new System.Drawing.Point(577, 104);
            this.txtAres.Name = "txtAres";
            this.txtAres.ReadOnly = true;
            this.txtAres.Size = new System.Drawing.Size(100, 20);
            this.txtAres.TabIndex = 19;
            // 
            // lblAres
            // 
            this.lblAres.AutoSize = true;
            this.lblAres.Location = new System.Drawing.Point(455, 111);
            this.lblAres.Name = "lblAres";
            this.lblAres.Size = new System.Drawing.Size(98, 13);
            this.lblAres.TabIndex = 18;
            this.lblAres.Text = "Area da residencia:";
            // 
            // btnVoltararea
            // 
            this.btnVoltararea.Location = new System.Drawing.Point(434, 380);
            this.btnVoltararea.Name = "btnVoltararea";
            this.btnVoltararea.Size = new System.Drawing.Size(75, 23);
            this.btnVoltararea.TabIndex = 45;
            this.btnVoltararea.Text = "voltar";
            this.btnVoltararea.UseVisualStyleBackColor = true;
            this.btnVoltararea.Click += new System.EventHandler(this.btnVoltararea_Click);
            // 
            // btnLimpararea
            // 
            this.btnLimpararea.Location = new System.Drawing.Point(241, 380);
            this.btnLimpararea.Name = "btnLimpararea";
            this.btnLimpararea.Size = new System.Drawing.Size(75, 23);
            this.btnLimpararea.TabIndex = 44;
            this.btnLimpararea.Text = "limpar";
            this.btnLimpararea.UseVisualStyleBackColor = true;
            this.btnLimpararea.Click += new System.EventHandler(this.btnLimpararea_Click);
            // 
            // txtLargcom
            // 
            this.txtLargcom.Location = new System.Drawing.Point(277, 92);
            this.txtLargcom.Name = "txtLargcom";
            this.txtLargcom.Size = new System.Drawing.Size(100, 20);
            this.txtLargcom.TabIndex = 46;
            // 
            // txtCompcom
            // 
            this.txtCompcom.Location = new System.Drawing.Point(277, 144);
            this.txtCompcom.Name = "txtCompcom";
            this.txtCompcom.Size = new System.Drawing.Size(100, 20);
            this.txtCompcom.TabIndex = 47;
            // 
            // lblLargcom
            // 
            this.lblLargcom.AutoSize = true;
            this.lblLargcom.Location = new System.Drawing.Point(88, 92);
            this.lblLargcom.Name = "lblLargcom";
            this.lblLargcom.Size = new System.Drawing.Size(130, 13);
            this.lblLargcom.TabIndex = 48;
            this.lblLargcom.Text = "largura do comodo(em M):";
            // 
            // lblCompcom
            // 
            this.lblCompcom.AutoSize = true;
            this.lblCompcom.Location = new System.Drawing.Point(88, 151);
            this.lblCompcom.Name = "lblCompcom";
            this.lblCompcom.Size = new System.Drawing.Size(162, 13);
            this.lblCompcom.TabIndex = 49;
            this.lblCompcom.Text = "Comprimento do comodo (em M):";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(335, 317);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 50;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblCompcom);
            this.Controls.Add(this.lblLargcom);
            this.Controls.Add(this.txtCompcom);
            this.Controls.Add(this.txtLargcom);
            this.Controls.Add(this.btnVoltararea);
            this.Controls.Add(this.btnLimpararea);
            this.Controls.Add(this.txtAres);
            this.Controls.Add(this.lblAres);
            this.Controls.Add(this.txtQtdcom);
            this.Controls.Add(this.txtAcom);
            this.Controls.Add(this.lblAcom);
            this.Controls.Add(this.lblQtdcom);
            this.Name = "frmArea";
            this.Text = "Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtQtdcom;
        private System.Windows.Forms.TextBox txtAcom;
        private System.Windows.Forms.Label lblAcom;
        private System.Windows.Forms.Label lblQtdcom;
        private System.Windows.Forms.TextBox txtAres;
        private System.Windows.Forms.Label lblAres;
        private System.Windows.Forms.Button btnVoltararea;
        private System.Windows.Forms.Button btnLimpararea;
        private System.Windows.Forms.TextBox txtLargcom;
        private System.Windows.Forms.TextBox txtCompcom;
        private System.Windows.Forms.Label lblLargcom;
        private System.Windows.Forms.Label lblCompcom;
        private System.Windows.Forms.Button btncalcular;
    }
}