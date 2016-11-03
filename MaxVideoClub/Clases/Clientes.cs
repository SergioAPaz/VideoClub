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
    class Clientes
    {
       
        public static SqlConnection conexion;
        Clases.Conexion c = new Clases.Conexion();
        SqlCommand sentencia;
        SqlDataReader reader;
        DataTable DataTable;
        SqlDataAdapter SqlDataAdapter;

        public Clientes()
        {
            try
            {
                conexion = new SqlConnection("Data Source=CONEXIONHPACER;Initial Catalog=videoclub_db1;Integrated Security=True");
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Base de datos no disponible, error en la conexion." + ex.ToString());
                throw;
            }
        }
        //CARGA DE CLIENTES EN DGV
        public void CargarClientes(DataGridView dgv)
        {
            try
            {
                SqlDataAdapter = new SqlDataAdapter("Select NumDeCliente,Nombre,Apellido,Edad,Telefono,Email,En_renta,Fecha_Alta,Folio_IFE from clientes", Properties.Settings.Default.Conexion);

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
        

        //GUARDAR CIENTES EN DB
        public string insertar(string Nombre,string Apellido, int Edad,string Telefono,string Email, string Ife)
        {
            string salida = "Guardado con exito.";
            
            int en_renta=0;

            String fecha = DateTime.Now.ToString("dd-MM-yyyy");

            Random AleatoryNumber = new Random(DateTime.Now.Minute);

            try
            {
              
                    sentencia = new SqlCommand("insert into clientes(Nombre,Apellido,Edad,NumDeCliente,Telefono,Email,En_renta,Fecha_Alta,Folio_IFE) values('" + Nombre + "','" + Apellido + "'," + Edad + "," + AleatoryNumber.Next() + ",'" + Telefono + "','" + Email + "'," + en_renta + ",'" + fecha + "','"+Ife+"')", conexion);

                    sentencia.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {
                salida = ("Error al guardar registro de cliente.  " + ex.ToString());


            }
            return salida;
        }

        //VALIDADOR DE REGISTRO YA EXISTENTE AL GUARDAR
        public int ClienteExistente(string Folio_IFE)
        {

            int Folio = Convert.ToInt32(Folio_IFE);
            int contador = 0;
            try
            {
                sentencia = new SqlCommand("select * from clientes where Folio_IFE=" + Folio + "  ",conexion);
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

        //CONSULTA ID EN BASE AL NumDeCliente DEL REGISTRO para mandar a frmModificarParther
        public void consultaID(int NumDeCliente)
        {
            sentencia = new SqlCommand("select id,Nombre,Apellido,Edad,Telefono,Email,Folio_IFE from clientes where NumDeCliente=" + NumDeCliente + "  ", conexion);

            reader = sentencia.ExecuteReader();
            String idValue = "";
            String NameValue = "";
            String ApellidoValue = "";
            String AgeValue = "";
            String PhoneValue = "";
            String EmailValue = "";
            String Folio_IFE = "";


            while (reader.Read())
            {
                idValue = (String.Format("{0}", reader["id"]));
                NameValue = (String.Format("{0}", reader["Nombre"]));
                ApellidoValue = (String.Format("{0}", reader["Apellido"]));
                AgeValue = (String.Format("{0}", reader["Edad"]));
                PhoneValue = (String.Format("{0}", reader["Telefono"]));
                EmailValue = (String.Format("{0}", reader["Email"]));
                Folio_IFE = (String.Format("{0}", reader["Folio_IFE"]));
            }
            reader.Close();

            frmModificarParther frmModificarParther = new frmModificarParther(idValue, NameValue, ApellidoValue, AgeValue, PhoneValue, EmailValue,Folio_IFE,NumDeCliente);

            frmModificarParther.ShowDialog();

        }



        //Metodo para Editar peliculas
        public string actualizar(string Nombre, string Apellido, int Edad, string Mail, int Ife,int Telefono, int NumDeCliente)
        {
            string salida = "Registro actualizado con exito.";
            String fecha1 = DateTime.Now.ToString("dd-MM-yyyy");

            try
            {
               

                sentencia = new SqlCommand("UPDATE clientes SET Nombre='" + Nombre + "', Apellido='" + Apellido + "',Edad=" + Edad + ",Email='" + Mail + "',Folio_IFE=" + Ife + ",Telefono="+ Telefono + " WHERE NumDeCliente=" + NumDeCliente + "  ", conexion);

                sentencia.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = ("Error al editar registro.  " + ex.ToString());


            }
            return salida;
        }
        //BORRAR REGISTRO DE DB
        public void DeleteRegistry(int NumDeClientes)
        {
            try
            {
                sentencia = new SqlCommand("DELETE FROM clientes WHERE NumDeCliente=" + NumDeClientes + "  ", conexion);

                sentencia.ExecuteNonQuery();

                MessageBox.Show("Registro eliminado con exito");
               

            }
            catch (Exception ex)
            {

                MessageBox.Show("Problemas al eliminar registro" + ex.ToString());
            }

        }

    }

}
