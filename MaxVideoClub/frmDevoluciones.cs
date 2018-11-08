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
    
    public partial class frmDevoluciones : Form
    {
        Clases.Devolucion Dev=new Clases.Devolucion();
        public frmDevoluciones()
        {
            InitializeComponent();
        }
        
        private void Devoluciones_Load(object sender, EventArgs e)
        {
            Dev.CargarDevoluciones(dgvDevoluciones);
            Dev.CargarMulta();
        }

        private void btnEfectuar_Click(object sender, EventArgs e)
        {

        }
    }
}
