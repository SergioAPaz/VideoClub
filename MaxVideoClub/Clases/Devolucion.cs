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

        SqlCommand CClienteExist;
        SqlDataReader RCClienteExist;

        SqlCommand CRelleno;
        SqlDataReader RCRelleno;

        DataTable DataTable;
        SqlDataAdapter SqlDataAdapter;

        SqlCommand SumaMulta;
      



        public Devolucion()
        {
            try
            {
                conexion = new SqlConnection("Data Source=CONEXIONHPACER;Initial Catalog=videoclub_db1;Integrated Security=True;MultipleActiveResultSets=True");
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Base de datos no disponible, error en la conexion." + ex.ToString());
                throw;
            }
        }
        //CARGA DE prestamos actuales EN DGV
        public void CargarDevoluciones(DataGridView dgv,string NumDeCliente)
        {
            try
            {
                int Cliente = Convert.ToInt32(NumDeCliente);
                SqlDataAdapter = new SqlDataAdapter("SELECT * FROM Prestamos WHERE NumeroDeCliente="+NumDeCliente+" ", Properties.Settings.Default.Conexion);

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
        //FUNCION PARA CARGAR MULTA DE $50 SI LA FECH DE DEVOLUCION ES ANTERIOR A LA FECHA ACTUAL 
        public void CargarMulta()
        {
            try
            {
                int x = 1;
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
                        //NO APLICA MULTA SIGUE ESTANDO EN PERIODO DE TOLERANCIA SE REGRESA A 0 EN CASO DE QUE TENGA MULTA POR CAMBIOS EN LA FECHA DEL EQUIPO SIN PRECAUCION
                        int y = 0;
                        //FUNCION PARA ASIGNAR MULTA CORRESPONDIENTE
                        SumaMulta = new SqlCommand("UPDATE Prestamos SET Multa=" + y + " WHERE id=" + Nid + "  ", conexion);

                        SumaMulta.ExecuteNonQuery();

                    }
                    else
                    {
                        if (CompararMulta==0)
                        {
                            if (x==1)
                            {
                                MessageBox.Show("Hay nuevas multas!");
                            }
                            x= 2;
                            int y = 50;
                            //FUNCION PARA ASIGNAR MULTA CORRESPONDIENTE
                            SumaMulta = new SqlCommand("UPDATE Prestamos SET Multa=" + y + " WHERE id=" + Nid + "  ", conexion);
                           
                            SumaMulta.ExecuteNonQuery();
                            
                           
                           
                        }
                        else 
                        {
                           
                           
                        }
                       
                    }
                 
                }
                RConsultaIDs.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible actulizar multas." + ex.ToString());
               
            }

            
        }

        public Boolean ConsulRentaExistente(string NumDeCliente)
        {
            Boolean Confirmacion=false;

            CClienteExist = new SqlCommand("SELECT NumeroDeCliente FROM Prestamos WHERE NumeroDeCliente="+NumDeCliente+" ", conexion);
            RCClienteExist = CClienteExist.ExecuteReader();

            while (RCClienteExist.Read())
            {
                Confirmacion = true;
            }
            RCClienteExist.Close();

            return Confirmacion;
        }

        


    }
   
}
