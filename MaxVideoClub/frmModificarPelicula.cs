﻿using System;
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
    public partial class frmModificarPelicula : Form
    {
        public frmModificarPelicula()
        {
            InitializeComponent();
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificarPelicula_Load(object sender, EventArgs e)
        {
            

        }
        public frmModificarPelicula(string id)
        {
            InitializeComponent();
            txtTitulo.Text = id;
        }
    }
}
