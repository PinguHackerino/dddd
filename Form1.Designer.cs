namespace ProgettoPosteBellizzi
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSportello = new System.Windows.Forms.Button();
            this.btnAccesso = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCode = new System.Windows.Forms.Button();
            this.cBSceltaServizio = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nokme = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(201, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "BENVENUTI ALLE POSTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleziona il servizio di cui hai bisogno";
            // 
            // btnSportello
            // 
            this.btnSportello.Location = new System.Drawing.Point(372, 251);
            this.btnSportello.Name = "btnSportello";
            this.btnSportello.Size = new System.Drawing.Size(162, 47);
            this.btnSportello.TabIndex = 4;
            this.btnSportello.Text = "Sportelli";
            this.btnSportello.UseVisualStyleBackColor = true;
            this.btnSportello.Click += new System.EventHandler(this.btnSportello_Click);
            // 
            // btnAccesso
            // 
            this.btnAccesso.Location = new System.Drawing.Point(405, 413);
            this.btnAccesso.Name = "btnAccesso";
            this.btnAccesso.Size = new System.Drawing.Size(116, 38);
            this.btnAccesso.TabIndex = 7;
            this.btnAccesso.Text = "Accesso";
            this.btnAccesso.UseVisualStyleBackColor = true;
            this.btnAccesso.Click += new System.EventHandler(this.btnAccesso_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Se sei dipendente effettua l\'accesso:";
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(527, 428);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(75, 23);
            this.btnCode.TabIndex = 9;
            this.btnCode.Text = "Code";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Visible = false;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // cBSceltaServizio
            // 
            this.cBSceltaServizio.FormattingEnabled = true;
            this.cBSceltaServizio.Items.AddRange(new object[] {
            "Pacchi",
            "Pagamento",
            "Ordinario",
            "Prestiti"});
            this.cBSceltaServizio.Location = new System.Drawing.Point(340, 194);
            this.cBSceltaServizio.Name = "cBSceltaServizio";
            this.cBSceltaServizio.Size = new System.Drawing.Size(228, 24);
            this.cBSceltaServizio.TabIndex = 1;
            this.cBSceltaServizio.SelectedIndexChanged += new System.EventHandler(this.cBSceltaServizio_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(712, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(870, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cognome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(870, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Data nascita";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(870, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // nokme
            // 
            this.nokme.AutoSize = true;
            this.nokme.Location = new System.Drawing.Point(870, 38);
            this.nokme.Name = "nokme";
            this.nokme.Size = new System.Drawing.Size(44, 16);
            this.nokme.TabIndex = 14;
            this.nokme.Text = "Nome";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(723, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(723, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(723, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(723, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(945, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nokme);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAccesso);
            this.Controls.Add(this.btnSportello);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBSceltaServizio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSportello;
        private System.Windows.Forms.Button btnAccesso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.ComboBox cBSceltaServizio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nokme;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

