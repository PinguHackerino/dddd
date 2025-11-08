using System;
using System.Linq;
using System.Windows.Forms;

namespace ProgettoPosteBellizzi
{

    public partial class Sportelli : Form
    {
      
        Form1 f1 = Form1.instance();

        public static Sportelli instance()
        {
            Sportelli form = Application.OpenForms.OfType<Sportelli>().FirstOrDefault();
            return form;
        }
        public Sportelli()
        {
            InitializeComponent();
        }

        private void btnIndietroS_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }

        private void rBPagamento_CheckedChanged(object sender, EventArgs e)
        {
            if (rBPagamento.Checked)
            {
                btnServiPa.Show();
                LWP.Show();
                label1.Show();
            }
            else if (!rBPagamento.Checked)
            {
                btnServiPa.Hide();
                LWP.Hide();
                label1.Hide();
            }
        }

        private void btnServiPa_Click(object sender, EventArgs e)
        {

        }


        private void rBOrdinario_CheckedChanged(object sender, EventArgs e)
        {
            if (rBOrdinario.Checked)
            {
                btnServiO.Show();
                LWO.Show();
                label2.Show();
            }
            else if (!rBOrdinario.Checked)
            {
                btnServiO.Hide();
                LWO.Hide();
                label2.Hide();
            }
        }

        private void rBPacchi_CheckedChanged(object sender, EventArgs e)
        {
            if (rBPacchi.Checked)
            {
                btnServiPc.Show();
                LWPac.Show();
                label3.Show();
            }
            else if (!rBPacchi.Checked)
            {
                btnServiPc.Hide();
                LWPac.Hide();
                label3.Hide();
            }
        }

        private void rBPrestiti_CheckedChanged(object sender, EventArgs e)
        {
            if (rBPrestiti.Checked)
            {
                btnServiPr.Show();
                LWPr.Show();
                label5.Show();
            }
            else if (!rBPrestiti.Checked)
            {
                btnServiPr.Hide();
                LWPr.Hide();
                label5 .Hide();
            }
        }

        private void btnServiPr_Click(object sender, EventArgs e)
        {

        }
        //public ListView LWO {  get; set; }
        public void LWO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LWP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sportelli_Load(object sender, EventArgs e)
        {

        }
    }
}
