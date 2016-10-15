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
        BindingSource bs = new BindingSource();
        Regex validar = new Regex(@"^[a-zA-Z0-9._ñÑáéíóúÁÉÍÓÚ ]+$"); /*Solo texto y numeros y _*/
        Regex validar2 = new Regex(@"^[0-9]+$"); /*Solo numeros*/
        
        



        public frmPeliculas()
        {
            InitializeComponent();
        }

        private void frmPeliculas_Load(object sender, EventArgs e)
        {
            txtFiltro.GotFocus += new EventHandler(this.TextGotFocus);
            txtFiltro.LostFocus += new EventHandler(this.TextLostFocus);
            c.CargarPeliculas(dgvPeliculas);
            NumerarTabla();





            DataGridViewButtonColumn ButtonColumn = new DataGridViewButtonColumn();
            ButtonColumn.Name = "Editar pelicula";
           

            int columnIndex = 7;

            if (dgvPeliculas.Columns["Editar pelicula"] == null)
            {
                dgvPeliculas.Columns.Insert(columnIndex, ButtonColumn);
            }
            dgvPeliculas.CellClick += dataGridViewSoftware_CellClick;





        }
        //BOTON PARA GUARDAR
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


        //FILTRO TXTBOX
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.Text=="Titulo")
            {
                
                ((DataTable)dgvPeliculas.DataSource).DefaultView.RowFilter = string.Format("Titulo like '%{0}%'", txtFiltro.Text.Trim().Replace("'", "''")     );
                NumerarTabla();
            }
            else if (cmbFiltro.Text == "Año")
            {
               
                ((DataTable)dgvPeliculas.DataSource).DefaultView.RowFilter = string.Format("Convert([Anio], System.String) like '%{0}%'", txtFiltro.Text.Trim());
                NumerarTabla();
            }
            else if (cmbFiltro.Text == "Genero")
            {
                
                ((DataTable)dgvPeliculas.DataSource).DefaultView.RowFilter = string.Format("Genero like '%{0}%'", txtFiltro.Text.Trim().Replace("'", "''"));
                NumerarTabla();
            }
            else if (cmbFiltro.Text == "Existencias")
            {
               
                ((DataTable)dgvPeliculas.DataSource).DefaultView.RowFilter = string.Format("Convert([Existencias], System.String) like '%{0}%'", txtFiltro.Text.Trim());
                NumerarTabla();
            }
            else if (cmbFiltro.Text == "Cualquiera...")
            {
                
                ((DataTable)dgvPeliculas.DataSource).DefaultView.RowFilter = string.Format("Convert([Anio], System.String) LIKE '%{0}%' OR [Titulo] LIKE '%{0}%' OR [Genero] LIKE '%{0}%' OR Convert([Existencias], System.String) LIKE '%{0}%' ", txtFiltro.Text.Trim());
                NumerarTabla();
            }



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void TextGotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Buscar...") 
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }
        public void TextLostFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text="Buscar...";
                tb.ForeColor = Color.LightGray;
                
                c.CargarPeliculas(dgvPeliculas);
                NumerarTabla();

            }
                    
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvPeliculas.Refresh();
            NumerarTabla();
        }


        //Funcion numeradora de rows en DataGridView
        public void NumerarTabla()
        {
            for (int i = 0; i < dgvPeliculas.Rows.Count; i++)
            {
                DataGridViewRowHeaderCell cell = dgvPeliculas.Rows[i].HeaderCell;
                cell.Value = (i + 1).ToString();
                dgvPeliculas.Rows[i].HeaderCell = cell;
            }
        }

        private void dataGridViewSoftware_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnI4ndex=1;

            String someString = dgvPeliculas[columnI4ndex, dgvPeliculas.CurrentCell.RowIndex].Value.ToString();

            string msg = String.Format("Row: {0}, Column: {1}",
     dgvPeliculas.CurrentCell.RowIndex,
     dgvPeliculas.CurrentCell.ColumnIndex);
            MessageBox.Show(msg, "Current Cell");

            MessageBox.Show(someString);
         
            c.consultaAnio(someString);


            

        }
        


    }

}

