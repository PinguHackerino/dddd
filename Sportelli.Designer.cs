namespace ProgettoPosteBellizzi
{
    partial class Sportelli
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
            this.btnIndietroS = new System.Windows.Forms.Button();
            this.btnServiPc = new System.Windows.Forms.Button();
            this.btnServiO = new System.Windows.Forms.Button();
            this.btnServiPa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LWP = new System.Windows.Forms.ListView();
            this.LWO = new System.Windows.Forms.ListView();
            this.LWPac = new System.Windows.Forms.ListView();
            this.rBPagamento = new System.Windows.Forms.RadioButton();
            this.rBOrdinario = new System.Windows.Forms.RadioButton();
            this.rBPacchi = new System.Windows.Forms.RadioButton();
            this.LWPr = new System.Windows.Forms.ListView();
            this.btnServiPr = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rBPrestiti = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnIndietroS
            // 
            this.btnIndietroS.BackColor = System.Drawing.Color.Yellow;
            this.btnIndietroS.Location = new System.Drawing.Point(367, 489);
            this.btnIndietroS.Name = "btnIndietroS";
            this.btnIndietroS.Size = new System.Drawing.Size(72, 26);
            this.btnIndietroS.TabIndex = 0;
            this.btnIndietroS.Text = "Indietro";
            this.btnIndietroS.UseVisualStyleBackColor = false;
            this.btnIndietroS.Click += new System.EventHandler(this.btnIndietroS_Click);
            // 
            // btnServiPc
            // 
            this.btnServiPc.Location = new System.Drawing.Point(28, 173);
            this.btnServiPc.Name = "btnServiPc";
            this.btnServiPc.Size = new System.Drawing.Size(203, 52);
            this.btnServiPc.TabIndex = 26;
            this.btnServiPc.Text = "Servi ";
            this.btnServiPc.UseVisualStyleBackColor = true;
            this.btnServiPc.Visible = false;
            // 
            // btnServiO
            // 
            this.btnServiO.Location = new System.Drawing.Point(28, 173);
            this.btnServiO.Name = "btnServiO";
            this.btnServiO.Size = new System.Drawing.Size(203, 52);
            this.btnServiO.TabIndex = 25;
            this.btnServiO.Text = "Servi ";
            this.btnServiO.UseVisualStyleBackColor = true;
            this.btnServiO.Visible = false;
            // 
            // btnServiPa
            // 
            this.btnServiPa.Location = new System.Drawing.Point(28, 173);
            this.btnServiPa.Name = "btnServiPa";
            this.btnServiPa.Size = new System.Drawing.Size(203, 52);
            this.btnServiPa.TabIndex = 24;
            this.btnServiPa.Text = "Servi ";
            this.btnServiPa.UseVisualStyleBackColor = true;
            this.btnServiPa.Visible = false;
            this.btnServiPa.Click += new System.EventHandler(this.btnServiPa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(23, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Pagamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(23, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ordinario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(23, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Pacchi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 48);
            this.label4.TabIndex = 29;
            this.label4.Text = "Sportello ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LWP
            // 
            this.LWP.HideSelection = false;
            this.LWP.Location = new System.Drawing.Point(28, 248);
            this.LWP.Name = "LWP";
            this.LWP.Size = new System.Drawing.Size(203, 267);
            this.LWP.TabIndex = 30;
            this.LWP.UseCompatibleStateImageBehavior = false;
            this.LWP.Visible = false;
            this.LWP.SelectedIndexChanged += new System.EventHandler(this.LWP_SelectedIndexChanged);
            // 
            // LWO
            // 
            this.LWO.HideSelection = false;
            this.LWO.Location = new System.Drawing.Point(357, 44);
            this.LWO.Name = "LWO";
            this.LWO.Size = new System.Drawing.Size(203, 267);
            this.LWO.TabIndex = 31;
            this.LWO.UseCompatibleStateImageBehavior = false;
            this.LWO.Visible = false;
            this.LWO.SelectedIndexChanged += new System.EventHandler(this.LWO_SelectedIndexChanged);
            // 
            // LWPac
            // 
            this.LWPac.HideSelection = false;
            this.LWPac.Location = new System.Drawing.Point(579, 44);
            this.LWPac.Name = "LWPac";
            this.LWPac.Size = new System.Drawing.Size(203, 267);
            this.LWPac.TabIndex = 32;
            this.LWPac.UseCompatibleStateImageBehavior = false;
            this.LWPac.Visible = false;
            // 
            // rBPagamento
            // 
            this.rBPagamento.AutoSize = true;
            this.rBPagamento.Location = new System.Drawing.Point(268, 176);
            this.rBPagamento.Name = "rBPagamento";
            this.rBPagamento.Size = new System.Drawing.Size(98, 20);
            this.rBPagamento.TabIndex = 33;
            this.rBPagamento.TabStop = true;
            this.rBPagamento.Text = "Pagamento";
            this.rBPagamento.UseVisualStyleBackColor = true;
            this.rBPagamento.CheckedChanged += new System.EventHandler(this.rBPagamento_CheckedChanged);
            // 
            // rBOrdinario
            // 
            this.rBOrdinario.AutoSize = true;
            this.rBOrdinario.Location = new System.Drawing.Point(268, 208);
            this.rBOrdinario.Name = "rBOrdinario";
            this.rBOrdinario.Size = new System.Drawing.Size(83, 20);
            this.rBOrdinario.TabIndex = 34;
            this.rBOrdinario.TabStop = true;
            this.rBOrdinario.Text = "Ordinario";
            this.rBOrdinario.UseVisualStyleBackColor = true;
            this.rBOrdinario.CheckedChanged += new System.EventHandler(this.rBOrdinario_CheckedChanged);
            // 
            // rBPacchi
            // 
            this.rBPacchi.AutoSize = true;
            this.rBPacchi.Location = new System.Drawing.Point(268, 236);
            this.rBPacchi.Name = "rBPacchi";
            this.rBPacchi.Size = new System.Drawing.Size(69, 20);
            this.rBPacchi.TabIndex = 35;
            this.rBPacchi.TabStop = true;
            this.rBPacchi.Text = "Pacchi";
            this.rBPacchi.UseVisualStyleBackColor = true;
            this.rBPacchi.CheckedChanged += new System.EventHandler(this.rBPacchi_CheckedChanged);
            // 
            // LWPr
            // 
            this.LWPr.HideSelection = false;
            this.LWPr.Location = new System.Drawing.Point(788, 44);
            this.LWPr.Name = "LWPr";
            this.LWPr.Size = new System.Drawing.Size(203, 267);
            this.LWPr.TabIndex = 36;
            this.LWPr.UseCompatibleStateImageBehavior = false;
            this.LWPr.Visible = false;
            // 
            // btnServiPr
            // 
            this.btnServiPr.Location = new System.Drawing.Point(28, 173);
            this.btnServiPr.Name = "btnServiPr";
            this.btnServiPr.Size = new System.Drawing.Size(203, 52);
            this.btnServiPr.TabIndex = 37;
            this.btnServiPr.Text = "Servi ";
            this.btnServiPr.UseVisualStyleBackColor = true;
            this.btnServiPr.Visible = false;
            this.btnServiPr.Click += new System.EventHandler(this.btnServiPr_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(23, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 26);
            this.label5.TabIndex = 38;
            this.label5.Text = "Prestiti";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // rBPrestiti
            // 
            this.rBPrestiti.AutoSize = true;
            this.rBPrestiti.Location = new System.Drawing.Point(268, 262);
            this.rBPrestiti.Name = "rBPrestiti";
            this.rBPrestiti.Size = new System.Drawing.Size(68, 20);
            this.rBPrestiti.TabIndex = 39;
            this.rBPrestiti.TabStop = true;
            this.rBPrestiti.Text = "Prestiti";
            this.rBPrestiti.UseVisualStyleBackColor = true;
            this.rBPrestiti.CheckedChanged += new System.EventHandler(this.rBPrestiti_CheckedChanged);
            // 
            // Sportelli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1029, 527);
            this.Controls.Add(this.rBPrestiti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnServiPr);
            this.Controls.Add(this.LWPr);
            this.Controls.Add(this.rBPacchi);
            this.Controls.Add(this.rBOrdinario);
            this.Controls.Add(this.rBPagamento);
            this.Controls.Add(this.LWPac);
            this.Controls.Add(this.LWO);
            this.Controls.Add(this.LWP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnServiPc);
            this.Controls.Add(this.btnServiO);
            this.Controls.Add(this.btnServiPa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIndietroS);
            this.Name = "Sportelli";
            this.Text = "Sportelli";
            this.Load += new System.EventHandler(this.Sportelli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIndietroS;
        private System.Windows.Forms.Button btnServiPc;
        private System.Windows.Forms.Button btnServiO;
        private System.Windows.Forms.Button btnServiPa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView LWP;
        private System.Windows.Forms.ListView LWO;
        private System.Windows.Forms.ListView LWPac;
        private System.Windows.Forms.RadioButton rBPagamento;
        private System.Windows.Forms.RadioButton rBOrdinario;
        private System.Windows.Forms.RadioButton rBPacchi;
        private System.Windows.Forms.ListView LWPr;
        private System.Windows.Forms.Button btnServiPr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rBPrestiti;
    }
}