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
    public partial class Code : Form
    {
        Form1 f1 = Form1.instance();
        public Code()
        {
            InitializeComponent();
        }

        private void btnCodeI_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }
    }
}
