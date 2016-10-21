using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxVideoClub
{
    public partial class frmPrincipal : Form
    {

        frmAdminsAccounts frmAdminsAccounts = new frmAdminsAccounts();
        frmPartners frmPartners = new frmPartners();
        frmPeliculas frmPeliculas = new frmPeliculas();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            frmAdminsAccounts.ShowDialog();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            frmPeliculas.ShowDialog();
        
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            frmPartners.ShowDialog();
        }
    }
}
