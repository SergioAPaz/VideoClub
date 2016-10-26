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
    public partial class frmModificarParther : Form
    {
        public frmModificarParther(string id,string Nombre,string Apellido, string Edad,string Telefono, string EmailValue, string Folio_IFE, int NumDeCliente)
        {
            InitializeComponent();

            

            String NumDeClienteTxt = Convert.ToString(NumDeCliente);
            txtNumDeCliente.Text = NumDeClienteTxt;
            txtId.Text = id;
            txtNombre.Text = Nombre;
            txtApellido.Text = Apellido;
            txtEdad.Text = Edad;
            txtTelefono.Text = Telefono;
            txtEmail.Text = EmailValue;
            txtIfe.Text = Folio_IFE;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificarParther_Load(object sender, EventArgs e)
        {

        }
    }
}
