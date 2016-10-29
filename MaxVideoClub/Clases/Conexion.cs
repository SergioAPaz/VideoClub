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
    public class Conexion
    {
        public static SqlConnection conexion;
        SqlCommand sentencia;
        SqlDataReader reader;
        DataTable DataTable;
        SqlDataAdapter SqlDataAdapter;

        public Conexion()
        {
            try
            {
                conexion = new SqlConnection("Data Source=CONEXIONHPACER;Initial Catalog=videoclub_db1;Integrated Security=True");
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Base de datos no disponib888le, error en la conexion." + ex.ToString());
               
            }
        }

        //Metodo para guardar peliculas
        public string insertar(string titulo, int anio, string genero, int existencias, string fecha)
        {
            string salida = "Guardado con exito.";
            int disponibles;
            int en_renta;

            Random AleatoryNumber = new Random(DateTime.Now.Millisecond);
           
            try
            {
                disponibles = existencias;
                en_renta = existencias - disponibles;
                
                for (int i = 0; i < existencias; i++)
                {
                    sentencia = new SqlCommand("insert into peliculas(Titulo,Anio,Genero,Existencias,Fecha_de_ingreso,Disponibles,En_renta,NumID) values('" + titulo + "'," + anio + ",'" + genero + "'," + existencias + ",'" + fecha + "'," + disponibles + "," + en_renta + "," + AleatoryNumber.Next() + ")", conexion);

                    sentencia.ExecuteNonQuery();
                }
             
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
                SqlDataAdapter = new SqlDataAdapter("Select NumID,Titulo,Anio,Genero,Existencias,En_renta,Disponibles,Fecha_de_ingreso from peliculas", Properties.Settings.Default.Conexion);
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


        //CONSULTA ID EN BASE AL TITULO DEL REGISTRO para mandar a frmModificarPelicula
        public void consultaID(int NumID)
        {
            sentencia = new SqlCommand("select id,Titulo,Anio,Genero,Existencias from peliculas where NumID=" + NumID + "  ", conexion);
            reader = sentencia.ExecuteReader();
            String idValue = "";
            String TituloValue = "";
            String AnioValue = "";
            String GeneroValue = "";
            String ExistenciasValue = "";
           

            while (reader.Read())
            {
                idValue = (String.Format("{0}", reader["id"]));
                TituloValue = (String.Format("{0}", reader["Titulo"]));
                AnioValue = (String.Format("{0}", reader["Anio"]));
                GeneroValue = (String.Format("{0}", reader["Genero"]));
                ExistenciasValue = (String.Format("{0}", reader["Existencias"]));
            }
            reader.Close();

            frmModificarPelicula frmModificarPelicula1 = new frmModificarPelicula(idValue,TituloValue, AnioValue, GeneroValue, ExistenciasValue,NumID);

            frmModificarPelicula1.ShowDialog();
            
        }



        //Metodo para Editar peliculas
        public string actualizar(string id,string titulo, int anio, string genero, int existencias)
        {
            string salida = "Registro actualizado con exito.";
            String fecha1 = DateTime.Now.ToString("dd-MM-yyyy");
           
            try
            {
                int disponibles = existencias;
                int en_renta = existencias - disponibles;
                
                sentencia = new SqlCommand("UPDATE peliculas SET Titulo='" +titulo+"', Anio="+anio+",Genero='"+genero+"',Existencias="+existencias+",Fecha_de_ingreso='"+fecha1+"' WHERE id="+id+"  ", conexion);

                sentencia.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                salida = ("Error al editar registro.  " + ex.ToString());


            }
            return salida;
        }

        public void DeleteRegistry(int NumIDValue)
        {   
            try
            {
                sentencia = new SqlCommand("DELETE FROM peliculas WHERE NumID="+ NumIDValue + "  ", conexion);
                
                sentencia.ExecuteNonQuery();
                
                MessageBox.Show("Registro eliminado con exito");

            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Problemas al eliminar registro"+ex.ToString());
            }
           
        }



    }
}
