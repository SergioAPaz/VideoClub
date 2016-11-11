using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MaxVideoClub
{
    public partial class frmModificarParther : Form
    {
        Clases.Conexion c = new Clases.Conexion();
        Clases.Clientes Cclients = new Clases.Clientes();
        Regex validar = new Regex(@"^[a-zA-Z0-9._ñÑáéíóúÁÉÍÓÚ@ ]+$"); /*Solo texto y numeros y _*/
        Regex validar2 = new Regex(@"^[0-9]+$"); /*Solo numeros*/

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
        //FUNCION QUE VALIDA QUE TODOS LOS CAMPOS ESTEN LLENOS 
        public Boolean EspaciosVacios()
        {
            Boolean rEspaciosVacios = false;

            if (String.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtApellido.Text) || String.IsNullOrWhiteSpace(txtEdad.Text) || String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtTelefono.Text) || String.IsNullOrWhiteSpace(txtIfe.Text))
            {
                rEspaciosVacios = true;
            }
            return rEspaciosVacios;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Boolean vRec = EspaciosVacios();
            String fecha = DateTime.Now.ToString("dd-MM-yyyy");
            if (vRec == false)
            {
                if (validar.IsMatch(txtNombre.Text) && validar.IsMatch(txtApellido.Text) && validar2.IsMatch(txtEdad.Text) && validar.IsMatch(txtEmail.Text) && validar2.IsMatch(txtIfe.Text) && validar2.IsMatch(txtTelefono.Text))
                {

                    try
                    {
                        Cclients.actualizar(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtEdad.Text), txtEmail.Text, txtIfe.Text,txtTelefono.Text,Convert.ToInt32(txtNumDeCliente.Text));

                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Imposible actualizar registro." + ex.ToString());
                    }



                }
                else
                {
                    MessageBox.Show("No se permiten caracteres especiales.");
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
        }
    }
}
