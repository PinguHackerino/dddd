using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPosteBellizzi
{
    public partial class Accesso2 : Form
    {
        public Accesso2()
        {
            InitializeComponent();
        }

        Form1 f1 = Form1.instance();

        public bool Logged;
        private void btnConferma_Click(object sender, EventArgs e)
        {
            //txtUtente.Text = txtUtente.ToString();
            //txtPassword.Text = txtPassword.ToString();

            if (txtUtente.Text == "Admin" && txtPassword.Text == "nimda")
            {
                MessageBox.Show("Accesso effettuato");
                Logged = true;
                f1.AttivaBtn();
            }
            else
            {
                MessageBox.Show("Accesso negato");
                Logged = false;
            }
            f1.Show();
            this.Hide();
        }

        private void btnIndeitroA_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }
    }
}
