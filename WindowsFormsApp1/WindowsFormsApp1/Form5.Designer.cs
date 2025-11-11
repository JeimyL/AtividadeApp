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
            this.btnCalfarea = new System.Windows.Forms.Button();
            this.btnCalfwarea = new System.Windows.Forms.Button();
            this.btnCalwarea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQtdcom
            // 
            this.txtQtdcom.Location = new System.Drawing.Point(242, 48);
            this.txtQtdcom.Name = "txtQtdcom";
            this.txtQtdcom.Size = new System.Drawing.Size(100, 20);
            this.txtQtdcom.TabIndex = 12;
            // 
            // txtAcom
            // 
            this.txtAcom.Location = new System.Drawing.Point(242, 92);
            this.txtAcom.Multiline = true;
            this.txtAcom.Name = "txtAcom";
            this.txtAcom.ReadOnly = true;
            this.txtAcom.Size = new System.Drawing.Size(100, 81);
            this.txtAcom.TabIndex = 11;
            // 
            // lblAcom
            // 
            this.lblAcom.AutoSize = true;
            this.lblAcom.Location = new System.Drawing.Point(88, 92);
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
            this.txtAres.Location = new System.Drawing.Point(242, 195);
            this.txtAres.Name = "txtAres";
            this.txtAres.ReadOnly = true;
            this.txtAres.Size = new System.Drawing.Size(100, 20);
            this.txtAres.TabIndex = 19;
            // 
            // lblAres
            // 
            this.lblAres.AutoSize = true;
            this.lblAres.Location = new System.Drawing.Point(88, 195);
            this.lblAres.Name = "lblAres";
            this.lblAres.Size = new System.Drawing.Size(98, 13);
            this.lblAres.TabIndex = 18;
            this.lblAres.Text = "Area da residencia:";
            // 
            // btnVoltararea
            // 
            this.btnVoltararea.Location = new System.Drawing.Point(347, 386);
            this.btnVoltararea.Name = "btnVoltararea";
            this.btnVoltararea.Size = new System.Drawing.Size(75, 23);
            this.btnVoltararea.TabIndex = 45;
            this.btnVoltararea.Text = "voltar";
            this.btnVoltararea.UseVisualStyleBackColor = true;
            // 
            // btnLimpararea
            // 
            this.btnLimpararea.Location = new System.Drawing.Point(154, 386);
            this.btnLimpararea.Name = "btnLimpararea";
            this.btnLimpararea.Size = new System.Drawing.Size(75, 23);
            this.btnLimpararea.TabIndex = 44;
            this.btnLimpararea.Text = "limpar";
            this.btnLimpararea.UseVisualStyleBackColor = true;
            // 
            // btnCalfarea
            // 
            this.btnCalfarea.Location = new System.Drawing.Point(438, 326);
            this.btnCalfarea.Name = "btnCalfarea";
            this.btnCalfarea.Size = new System.Drawing.Size(75, 23);
            this.btnCalfarea.TabIndex = 43;
            this.btnCalfarea.Text = "calfor";
            this.btnCalfarea.UseVisualStyleBackColor = true;
            // 
            // btnCalfwarea
            // 
            this.btnCalfwarea.Location = new System.Drawing.Point(256, 326);
            this.btnCalfwarea.Name = "btnCalfwarea";
            this.btnCalfwarea.Size = new System.Drawing.Size(75, 23);
            this.btnCalfwarea.TabIndex = 42;
            this.btnCalfwarea.Text = "cal fwille";
            this.btnCalfwarea.UseVisualStyleBackColor = true;
            // 
            // btnCalwarea
            // 
            this.btnCalwarea.Location = new System.Drawing.Point(64, 327);
            this.btnCalwarea.Name = "btnCalwarea";
            this.btnCalwarea.Size = new System.Drawing.Size(75, 23);
            this.btnCalwarea.TabIndex = 41;
            this.btnCalwarea.Text = "cal Wille";
            this.btnCalwarea.UseVisualStyleBackColor = true;
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltararea);
            this.Controls.Add(this.btnLimpararea);
            this.Controls.Add(this.btnCalfarea);
            this.Controls.Add(this.btnCalfwarea);
            this.Controls.Add(this.btnCalwarea);
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
        private System.Windows.Forms.Button btnCalfarea;
        private System.Windows.Forms.Button btnCalfwarea;
        private System.Windows.Forms.Button btnCalwarea;
    }
}