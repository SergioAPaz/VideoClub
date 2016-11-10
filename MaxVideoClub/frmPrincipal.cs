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
        frmRenta frmRenta = new frmRenta();
        frmRentasActuales frmRentasActuales = new frmRentasActuales();
        frmDevoluciones frmDevoluciones = new frmDevoluciones();
        frmLogin frmLogin = new frmLogin();
        Clases.Principal CPrincipal=new Clases.Principal();
        string USerValidation
        {
            get; set;
        }
        public frmPrincipal(string User)
        {
            USerValidation = User;
            InitializeComponent();
            lblUser.Text = User;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            String Val = USerValidation;
            if (CPrincipal.TipoDeUsuario(Val)==true)
            {
                button5.Enabled = true;
                MessageBox.Show("Iniciando como administrador.");
            }
            else
            {
                button5.Enabled = false;
            }
            CPrincipal.TipoDeUsuario(Val);
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

        private void button2_Click(object sender, EventArgs e)
        {
            frmRenta.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmRentasActuales.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmDevoluciones.ShowDialog();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Controls.Clear();

            this.InitializeComponent();
            frmLogin.Show();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            this.Controls.Clear();

            this.InitializeComponent();
            frmLogin.Show();
        }
    }
}
