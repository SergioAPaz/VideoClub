using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MaxVideoClub.Clases
{
    class Conexion
    {
        SqlConnection conexion;
        SqlCommand sentencia;
        SqlDataReader reader;
        DataTable DataTable;
        SqlDataAdapter SqlDataAdapter;

        public Conexion()
        {
            try
            {
                conexion = new SqlConnection("Data Source=.;Initial Catalog=videoclub_db1;Integrated Security=True");
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Base de datos no disponible, error en la conexion." + ex.ToString());
                throw;
            }
        }

        //Metodo para guardar peliculas
        public string insertar(string titulo, int anio, string genero, int existencias, string fecha)
        {
            string salida = "Guardado con exito.";
            int disponibles;
            int en_renta;
            try
            {
                disponibles = existencias;
                en_renta = existencias - disponibles;

                sentencia = new SqlCommand("insert into peliculas(Titulo,Anio,Genero,Existencias,Fecha_de_ingreso,Disponibles,En_renta) values('" + titulo + "'," + anio + ",'" + genero + "'," + existencias + ",'" + fecha + "'," + disponibles + "," + en_renta + ")", conexion);

                sentencia.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = ("Error al guardar registro.  " + ex.ToString());
                
            }
            return salida;
        }

        //Metodo que verifica si ya existe la pelicula en DB
        public int PeliculasExistentes(string titulo)
        {
            int contador = 0;
            try
            {
                sentencia = new SqlCommand("select * from peliculas where Titulo='" + titulo + "'  ", conexion);
                reader = sentencia.ExecuteReader();
                while (reader.Read())
                {
                    contador++;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible realizar consulta de existencias.  " + ex.ToString());
                throw;
            }
            return contador;
        }

        //CARGAR PELICULAS DENTRO DE DATAGRIDVIEW
        public void CargarPeliculas(DataGridView dgv)
        {
            try
            {
                SqlDataAdapter = new SqlDataAdapter("Select Titulo,Anio,Genero,Existencias,Fecha_de_ingreso,En_renta,Disponibles from peliculas", conexion);
                DataTable = new DataTable();
                SqlDataAdapter.Fill(DataTable);
                dgv.DataSource = DataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible llenar tabla con el contenido" + ex.ToString());
                throw;
            }
        }

    }
}
