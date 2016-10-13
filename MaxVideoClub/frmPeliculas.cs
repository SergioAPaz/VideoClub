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
    public partial class frmPeliculas : Form
    {
        Clases.Conexion c = new Clases.Conexion();
        
        Regex validar = new Regex(@"^[a-zA-Z0-9._ñÑáéíóúÁÉÍÓÚ ]+$"); /*Solo texto y numeros y _*/
        Regex validar2 = new Regex(@"^[0-9]+$"); /*Solo numeros*/





        public frmPeliculas()
        {
            InitializeComponent();
        }

        private void frmPeliculas_Load(object sender, EventArgs e)
        {
            Clases.Conexion c = new Clases.Conexion();
            c.CargarPeliculas(dgvPeliculas);
            
            //Columna Contadora de rows en DataGridView
            for (int i = 0; i < dgvPeliculas.Rows.Count; i++)
            {
                DataGridViewRowHeaderCell cell = dgvPeliculas.Rows[i].HeaderCell;
                cell.Value = (i + 1).ToString();
                dgvPeliculas.Rows[i].HeaderCell = cell;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean vRec= EspaciosVacios();
            String fecha = DateTime.Now.ToString("dd-MM-yyyy");
            if (vRec == false)
            {
                if (validar.IsMatch(txtTitulo.Text) && validar2.IsMatch(txtAnio.Text) && validar.IsMatch(txtGenero.Text) && validar2.IsMatch(txtExistencias.Text))
                {
                    if (c.PeliculasExistentes(txtTitulo.Text) == 0)
                    {
                        MessageBox.Show(c.insertar(txtTitulo.Text, Convert.ToInt32(txtAnio.Text), txtGenero.Text, Convert.ToInt32(txtExistencias.Text),fecha));
                        c.CargarPeliculas(dgvPeliculas);
                        txtGenero.Text = "";
                        txtTitulo.Text = "";
                        txtAnio.Text = "";
                        txtExistencias.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Imposible, la pelicula ya existe.");
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

        //Clase que valida que esten llenos todos los campos
         public  Boolean EspaciosVacios()
        {
            Boolean rEspaciosVacios = false;

            if (String.IsNullOrWhiteSpace(txtTitulo.Text) || String.IsNullOrWhiteSpace(txtAnio.Text) || String.IsNullOrWhiteSpace(txtExistencias.Text) || String.IsNullOrWhiteSpace(txtGenero.Text))
            {
                rEspaciosVacios = true;
            }
            return rEspaciosVacios;
        }



        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
