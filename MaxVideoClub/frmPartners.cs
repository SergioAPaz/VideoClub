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
    public partial class frmPartners : Form
    {
        Clases.Conexion c = new Clases.Conexion();
        Clases.Clientes clients = new Clases.Clientes();



        public frmPartners()
        {
            InitializeComponent();
        }

        private void txtAnio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmPartners_Load(object sender, EventArgs e)
        {
            clients.CargarClientes(dgvParthers);
        }
    }
}
