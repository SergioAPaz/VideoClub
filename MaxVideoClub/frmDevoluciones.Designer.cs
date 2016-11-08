namespace MaxVideoClub
{
    partial class frmDevoluciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEfectuar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFechaDevolucion = new System.Windows.Forms.TextBox();
            this.txtPagar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.acercaDeMaxVideoClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtFecha = new System.Windows.Forms.ToolStripLabel();
            this.stripName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgvDevoluciones = new System.Windows.Forms.DataGridView();
            this.txtNumDeCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEfectuar
            // 
            this.btnEfectuar.Enabled = false;
            this.btnEfectuar.Location = new System.Drawing.Point(846, 136);
            this.btnEfectuar.Name = "btnEfectuar";
            this.btnEfectuar.Size = new System.Drawing.Size(137, 23);
            this.btnEfectuar.TabIndex = 29;
            this.btnEfectuar.Text = "Actualizar";
            this.btnEfectuar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEfectuar.UseVisualStyleBackColor = true;
            this.btnEfectuar.Click += new System.EventHandler(this.btnEfectuar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("NewsGoth Lt BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Buscar por:";
            // 
            // txtFechaDevolucion
            // 
            this.txtFechaDevolucion.Location = new System.Drawing.Point(159, 60);
            this.txtFechaDevolucion.Name = "txtFechaDevolucion";
            this.txtFechaDevolucion.ReadOnly = true;
            this.txtFechaDevolucion.Size = new System.Drawing.Size(133, 22);
            this.txtFechaDevolucion.TabIndex = 8;
            // 
            // txtPagar
            // 
            this.txtPagar.Enabled = false;
            this.txtPagar.Location = new System.Drawing.Point(484, 22);
            this.txtPagar.Name = "txtPagar";
            this.txtPagar.ReadOnly = true;
            this.txtPagar.Size = new System.Drawing.Size(116, 22);
            this.txtPagar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total a pagar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de devolucion:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPagar);
            this.groupBox2.Controls.Add(this.txtFechaDevolucion);
            this.groupBox2.Controls.Add(this.txtPagar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPelicula);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(351, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(632, 100);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // btnPagar
            // 
            this.btnPagar.Enabled = false;
            this.btnPagar.Location = new System.Drawing.Point(506, 56);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(94, 33);
            this.btnPagar.TabIndex = 9;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtPelicula
            // 
            this.txtPelicula.Enabled = false;
            this.txtPelicula.Location = new System.Drawing.Point(77, 20);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.ReadOnly = true;
            this.txtPelicula.Size = new System.Drawing.Size(215, 22);
            this.txtPelicula.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pelicula:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Enabled = false;
            this.txtFiltro.ForeColor = System.Drawing.Color.LightGray;
            this.txtFiltro.Location = new System.Drawing.Point(258, 138);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(279, 22);
            this.txtFiltro.TabIndex = 22;
            this.txtFiltro.Text = "Buscar...";
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // acercaDeMaxVideoClubToolStripMenuItem
            // 
            this.acercaDeMaxVideoClubToolStripMenuItem.Name = "acercaDeMaxVideoClubToolStripMenuItem";
            this.acercaDeMaxVideoClubToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.acercaDeMaxVideoClubToolStripMenuItem.Text = "Acerca de MaxVideoClub";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.acercaDeMaxVideoClubToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(59, 24);
            this.toolStripDropDownButton1.Tag = "gfgfhg";
            this.toolStripDropDownButton1.Text = "Inicio";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.txtFecha});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(993, 27);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // txtFecha
            // 
            this.txtFecha.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(111, 24);
            this.txtFecha.Text = "toolStripLabel1";
            this.txtFecha.Click += new System.EventHandler(this.txtFecha_Click);
            // 
            // stripName
            // 
            this.stripName.ForeColor = System.Drawing.Color.White;
            this.stripName.Name = "stripName";
            this.stripName.Size = new System.Drawing.Size(66, 20);
            this.stripName.Text = "Ninguno";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 20);
            this.toolStripStatusLabel1.Text = "Cliente:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stripName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(993, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dgvDevoluciones
            // 
            this.dgvDevoluciones.AllowUserToAddRows = false;
            this.dgvDevoluciones.AllowUserToDeleteRows = false;
            this.dgvDevoluciones.AllowUserToOrderColumns = true;
            this.dgvDevoluciones.AllowUserToResizeRows = false;
            this.dgvDevoluciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDevoluciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDevoluciones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevoluciones.Enabled = false;
            this.dgvDevoluciones.Location = new System.Drawing.Point(12, 171);
            this.dgvDevoluciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDevoluciones.MultiSelect = false;
            this.dgvDevoluciones.Name = "dgvDevoluciones";
            this.dgvDevoluciones.ReadOnly = true;
            this.dgvDevoluciones.RowTemplate.Height = 24;
            this.dgvDevoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevoluciones.Size = new System.Drawing.Size(971, 301);
            this.dgvDevoluciones.TabIndex = 21;
            this.dgvDevoluciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevoluciones_CellContentClick);
            this.dgvDevoluciones.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.pintar_numeros);
            // 
            // txtNumDeCliente
            // 
            this.txtNumDeCliente.Location = new System.Drawing.Point(135, 20);
            this.txtNumDeCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumDeCliente.MaxLength = 12;
            this.txtNumDeCliente.Name = "txtNumDeCliente";
            this.txtNumDeCliente.Size = new System.Drawing.Size(184, 22);
            this.txtNumDeCliente.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumDeCliente);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(332, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero de Cliente:";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.Enabled = false;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Titulo de pelicula",
            "Numero de cliente",
            "Nombre de cliente",
            "Fecha de entrega",
            "Fecha de devolucion",
            "Multa",
            "Cualquiera..."});
            this.cmbFiltro.Location = new System.Drawing.Point(89, 136);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(159, 24);
            this.cmbFiltro.TabIndex = 30;
            // 
            // frmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 503);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.btnEfectuar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvDevoluciones);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDevoluciones";
            this.Text = "Devoluciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDevoluciones_FormClosing);
            this.Load += new System.EventHandler(this.Devoluciones_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEfectuar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFechaDevolucion;
        private System.Windows.Forms.TextBox txtPagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeMaxVideoClubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dgvDevoluciones;
        private System.Windows.Forms.TextBox txtNumDeCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripLabel txtFecha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ComboBox cmbFiltro;
    }
}