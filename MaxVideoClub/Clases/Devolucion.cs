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
    class Devolucion
    {
        public static SqlConnection conexion;
        Clases.Conexion c = new Clases.Conexion();
        SqlCommand ConsultaIDs;
        SqlDataReader RConsultaIDs;
        DataTable DataTable;
        SqlDataAdapter SqlDataAdapter;

        SqlCommand SumaMulta;
      



        public Devolucion()
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
        //CARGA DE prestamos ctuales EN DGV
        public void CargarDevoluciones(DataGridView dgv)
        {
            try
            {
                SqlDataAdapter = new SqlDataAdapter("SELECT TituloDePelicula,NumeroDeCliente,NombreDeCliente,Fecha_De_Entrega,Fecha_De_Devolucion,Multa FROM Prestamos", Properties.Settings.Default.Conexion);

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

        public void CargarMulta()
        {
            try
            {
                String Fecha = DateTime.Now.ToString("dd-MM-yyyy");
                DateTime hoy = DateTime.ParseExact(Fecha, "dd-MM-yyyy",
                                         System.Globalization.CultureInfo.InvariantCulture);

                ConsultaIDs = new SqlCommand("SELECT id,Fecha_De_Devolucion,Multa FROM Prestamos", conexion);
                RConsultaIDs = ConsultaIDs.ExecuteReader();
                String ID = "";
                String VFdevol = "";
                String Multa="";
                while (RConsultaIDs.Read())
                {
                    ID = (String.Format("{0}", RConsultaIDs["id"]));
                    int Nid = Convert.ToInt32(ID);
                    VFdevol = (String.Format("{0}", RConsultaIDs["Fecha_De_Devolucion"]));

                    DateTime Fdevol = DateTime.ParseExact(VFdevol, "dd-MM-yyyy",
                                          System.Globalization.CultureInfo.InvariantCulture);

                    Multa = (String.Format("{0}", RConsultaIDs["Multa"]));
                    int CompararMulta = Convert.ToInt32(Multa);
                    if (Fdevol > hoy)
                    {
                        //NO APLICA MULTA SIGUE ESTANDO EN PERIODO DE TOLERANCIA
                       
                    }
                    else
                    {
                        if (CompararMulta==0)
                        {
                            //FUNCION PARA ASIGNAR MULTA CORRESPONDIENTE
                            SumaMulta = new SqlCommand("UPDATE Prestamos SET Multa=" + 50 + " WHERE id=" + Nid + "  ", conexion);
                            SumaMulta.ExecuteNonQuery();
                            MessageBox.Show("Hay nuevas multas!");
                           
                        }
                        else 
                        {
                            //LA MULTA YA FUE APLICADA ANTERIORMENTE
                           
                        }
                       
                    }
                 
                }
                RConsultaIDs.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible actulizar multas." + ex.ToString());
                throw;
            }
        }


    }
   
}
