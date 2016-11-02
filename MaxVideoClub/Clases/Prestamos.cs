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
    class Prestamos
    {
        public static SqlConnection conexion;
        Clases.Conexion c = new Clases.Conexion();
        SqlCommand sentencia;
        SqlDataReader reader;
        DataTable DataTable;
        SqlDataAdapter SqlDataAdapter;

        public Prestamos()
        {
            try
            {
                conexion = new SqlConnection("Data Source=CONEXIONHPACER;Initial Catalog=videoclub_db1;Integrated Security=True");
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Base de datos no disponib777777le, error en la conexion." + ex.ToString());
                throw;
            }
        }
        //CONSULTA DE EXISTENCIAS PARA REGRESAR A FRMRENTAS
        public string ConsultaRelleno(string Titulo)
        {
            String Existencias = "";
             try
            {
                sentencia = new SqlCommand("SELECT Existencias FROM peliculas WHERE Titulo='"+Titulo+"' ", conexion);
                
                reader = sentencia.ExecuteReader();

                while (reader.Read())
                {
                    Existencias = (String.Format("{0}", reader["Existencias"]));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al consultar existencias" + ex.ToString());
            }

            return Existencias;
        }

       
    }
}
