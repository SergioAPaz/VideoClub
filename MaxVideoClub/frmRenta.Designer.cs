﻿namespace MaxVideoClub
{
    partial class frmRenta
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumDeCliente = new System.Windows.Forms.TextBox();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeMaxVideoClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPelicula = new System.Windows.Forms.TextBox();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaEntrega = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnEfectuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // txtNumDeCliente
            // 
            this.txtNumDeCliente.Location = new System.Drawing.Point(135, 20);
            this.txtNumDeCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumDeCliente.MaxLength = 12;
            this.txtNumDeCliente.Name = "txtNumDeCliente";
            this.txtNumDeCliente.Size = new System.Drawing.Size(184, 22);
            this.txtNumDeCliente.TabIndex = 4;
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.AllowUserToDeleteRows = false;
            this.dgvPeliculas.AllowUserToOrderColumns = true;
            this.dgvPeliculas.AllowUserToResizeRows = false;
            this.dgvPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPeliculas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPeliculas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Enabled = false;
            this.dgvPeliculas.Location = new System.Drawing.Point(12, 171);
            this.dgvPeliculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPeliculas.MultiSelect = false;
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.ReadOnly = true;
            this.dgvPeliculas.RowTemplate.Height = 24;
            this.dgvPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeliculas.Size = new System.Drawing.Size(971, 301);
            this.dgvPeliculas.TabIndex = 6;
            this.dgvPeliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeliculas_CellContentClick);
            this.dgvPeliculas.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.pintar);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stripName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(995, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 20);
            this.toolStripStatusLabel1.Text = "Cliente:";
            // 
            // stripName
            // 
            this.stripName.ForeColor = System.Drawing.Color.White;
            this.stripName.Name = "stripName";
            this.stripName.Size = new System.Drawing.Size(66, 20);
            this.stripName.Text = "Ninguno";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(995, 27);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
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
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // acercaDeMaxVideoClubToolStripMenuItem
            // 
            this.acercaDeMaxVideoClubToolStripMenuItem.Name = "acercaDeMaxVideoClubToolStripMenuItem";
            this.acercaDeMaxVideoClubToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.acercaDeMaxVideoClubToolStripMenuItem.Text = "Acerca de MaxVideoClub";
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
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPelicula);
            this.groupBox2.Controls.Add(this.txtExistencias);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpDevolucion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtFechaEntrega);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(351, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(632, 100);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // cmbPelicula
            // 
            this.cmbPelicula.Location = new System.Drawing.Point(88, 22);
            this.cmbPelicula.Name = "cmbPelicula";
            this.cmbPelicula.ReadOnly = true;
            this.cmbPelicula.Size = new System.Drawing.Size(215, 22);
            this.cmbPelicula.TabIndex = 8;
            // 
            // txtExistencias
            // 
            this.txtExistencias.Enabled = false;
            this.txtExistencias.Location = new System.Drawing.Point(484, 22);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.ReadOnly = true;
            this.txtExistencias.Size = new System.Drawing.Size(116, 22);
            this.txtExistencias.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "Existencias antes \r\nde renta:";
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.CustomFormat = "dd-MM-yyyy";
            this.dtpDevolucion.Enabled = false;
            this.dtpDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDevolucion.Location = new System.Drawing.Point(484, 60);
            this.dtpDevolucion.MinDate = new System.DateTime(2016, 10, 5, 0, 0, 0, 0);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(116, 22);
            this.dtpDevolucion.TabIndex = 5;
            this.dtpDevolucion.Value = new System.DateTime(2016, 12, 25, 23, 59, 59, 0);
            this.dtpDevolucion.ValueChanged += new System.EventHandler(this.dtpDevolucion_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de devolucion:";
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.Enabled = false;
            this.txtFechaEntrega.Location = new System.Drawing.Point(148, 60);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.ReadOnly = true;
            this.txtFechaEntrega.Size = new System.Drawing.Size(155, 22);
            this.txtFechaEntrega.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de entrega:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pelicula:";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.Enabled = false;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Titulo",
            "Año",
            "Genero",
            "Existencias",
            "Disponibles",
            "Cualquiera..."});
            this.cmbFiltro.Location = new System.Drawing.Point(90, 138);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltro.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("NewsGoth Lt BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Buscar por:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Enabled = false;
            this.txtFiltro.ForeColor = System.Drawing.Color.LightGray;
            this.txtFiltro.Location = new System.Drawing.Point(223, 138);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(279, 22);
            this.txtFiltro.TabIndex = 8;
            this.txtFiltro.Text = "Buscar...";
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnEfectuar
            // 
            this.btnEfectuar.Enabled = false;
            this.btnEfectuar.Location = new System.Drawing.Point(846, 136);
            this.btnEfectuar.Name = "btnEfectuar";
            this.btnEfectuar.Size = new System.Drawing.Size(137, 23);
            this.btnEfectuar.TabIndex = 20;
            this.btnEfectuar.Text = "Efectuar renta";
            this.btnEfectuar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEfectuar.UseVisualStyleBackColor = true;
            this.btnEfectuar.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 505);
            this.Controls.Add(this.btnEfectuar);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvPeliculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmRenta";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Renta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRenta_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AlCerrar);
            this.Load += new System.EventHandler(this.frmRenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumDeCliente;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeMaxVideoClubToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFechaEntrega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnEfectuar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel stripName;
        private System.Windows.Forms.TextBox cmbPelicula;
    }
}