using System;
using System.Linq;
using System.Windows.Forms;

namespace ProgettoPosteBellizzi
{
    public partial class Form1 : Form
    {
        public static Form1 instance()
        {
            Form1 form = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            return form;
        }
        Sportelli sportelli = Sportelli.instance();
        public Form1()
        {
            InitializeComponent();
        }

        private void cBSceltaServizio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Sportelli sportelli = new Sportelli();
            string str = cBSceltaServizio.Text.ToString();
            if (str == "Ordinario")
            {
                MessageBox.Show("Aggiunto allo sportello ordinario");
                //sportelli.LWO.Items.Add(c);
            }
            else if (str == "Pacchi")
            {
                MessageBox.Show("Aggiunto allo sportello Pacchi");

            }
            else if (str == "Prestiti")
            {
                MessageBox.Show("Aggiunto allo sportello Prestiti");

            }
            else
            {
                MessageBox.Show("Aggiunto allo sportello Pagamenti");

            }
        }

        private void btnAccesso_Click(object sender, EventArgs e)
        {
            Accesso2 accesso = new Accesso2();
            this.Hide();
            accesso.Show();
            //if (accesso.Logged == true)
            //    btnCode.Show();
            //else
            //    btnCode.Hide();
        }
        private void btnSportello_Click(object sender, EventArgs e)
        {
            Sportelli sportelli = new Sportelli();
            this.Hide();
            sportelli.ShowDialog();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            Accesso2 accesso = new Accesso2();
            Code code = new Code();
            this.Hide();
            code.ShowDialog();
        }

        public void AttivaBtn()
        {
            btnCode.Visible = true;
        }

        public void SceltaO()
        {
            string str = cBSceltaServizio.Text.ToString();
            if (str == "Ordinario")
            {
                MessageBox.Show("Aggiunto allo sportello ordinario");

            }
        }
        public void SceltaP()
        {
            string str = cBSceltaServizio.Text.ToString();
            if (str == "Ordinario")
            {
                MessageBox.Show("Aggiunto allo sportello ordinario");

            }
            else if (str == "Pacchi")
            {
                MessageBox.Show("Aggiunto allo sportello Pacchi");

            }
            else if (str == "Prestiti")
            {
                MessageBox.Show("Aggiunto allo sportello Prestiti");

            }
            else
            {
                MessageBox.Show("Aggiunto allo sportello Pagamenti");

            }
        }
    }
}
