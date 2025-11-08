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
            SceltaP();
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

        public void SceltaO() // ????
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
                Cliente o= new Cliente("O", "indeterminato"); // creazione dell'oggetto Cliente con tipo "O" e durata "indeterminato"
                //Ufficio_Postale.AggiungiCliente(c, "ordinario");
                MessageBox.Show("Aggiunto allo sportello ordinario, con cod ce: " + o.Codice.ToString()); // stampa del messaggio con il codice del cliente
                // sportelli.LWO.Items.Add(c);

            }
            else if (str == "Pacchi")
            {
                Cliente p = new Cliente("P", "indeterminato"); // stessa cosa per i pacchi

                MessageBox.Show("Aggiunto allo sportello Pacchi, con codice: "+ p.Codice.ToString());

            }
            else if (str == "Prestiti")
            {
                MessageBox.Show("Aggiunto allo sportello Prestiti"); // non l'ho fatto perchè è negli opzionali

            }
            else
            {
                Cliente pa = new Cliente("PA", "indeterminato"); // PA sta per pagamenti
                MessageBox.Show("Aggiunto allo sportello Pagamenti, con codice: " + pa.Codice.ToString());

            }
        }
    }
}
