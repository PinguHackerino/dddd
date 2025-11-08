namespace ProgettoPosteBellizzi
{
    partial class Accesso2
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnIndeitroA = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUtente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(373, 178);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(152, 22);
            this.txtPassword.TabIndex = 29;
            // 
            // btnIndeitroA
            // 
            this.btnIndeitroA.BackColor = System.Drawing.Color.Yellow;
            this.btnIndeitroA.Location = new System.Drawing.Point(101, 355);
            this.btnIndeitroA.Name = "btnIndeitroA";
            this.btnIndeitroA.Size = new System.Drawing.Size(75, 23);
            this.btnIndeitroA.TabIndex = 28;
            this.btnIndeitroA.Text = "Indietro";
            this.btnIndeitroA.UseVisualStyleBackColor = false;
            this.btnIndeitroA.Click += new System.EventHandler(this.btnIndeitroA_Click);
            // 
            // btnConferma
            // 
            this.btnConferma.BackColor = System.Drawing.Color.Yellow;
            this.btnConferma.Location = new System.Drawing.Point(413, 219);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 27;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = false;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Utente";
            // 
            // txtUtente
            // 
            this.txtUtente.Location = new System.Drawing.Point(373, 133);
            this.txtUtente.Name = "txtUtente";
            this.txtUtente.Size = new System.Drawing.Size(152, 22);
            this.txtUtente.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(179, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Per continuare come dipendete effettuare l\'accesso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Accesso2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnIndeitroA);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUtente);
            this.Controls.Add(this.label1);
            this.Name = "Accesso2";
            this.Text = "Accesso2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnIndeitroA;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUtente;
        private System.Windows.Forms.Label label1;
    }
}