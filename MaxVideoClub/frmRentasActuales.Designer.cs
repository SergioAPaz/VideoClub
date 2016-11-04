namespace MaxVideoClub
{
    partial class frmRentasActuales
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
            this.dgvRentas = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeMaxVideoClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRentas
            // 
            this.dgvRentas.AllowUserToAddRows = false;
            this.dgvRentas.AllowUserToDeleteRows = false;
            this.dgvRentas.AllowUserToOrderColumns = true;
            this.dgvRentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRentas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentas.Location = new System.Drawing.Point(12, 67);
            this.dgvRentas.Name = "dgvRentas";
            this.dgvRentas.ReadOnly = true;
            this.dgvRentas.RowTemplate.Height = 24;
            this.dgvRentas.Size = new System.Drawing.Size(960, 414);
            this.dgvRentas.TabIndex = 0;
            this.dgvRentas.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.pintar_numeros);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
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
            this.toolStrip1.Size = new System.Drawing.Size(984, 27);
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
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Titulo de pelicula",
            "Numero de cliente",
            "Nombre de cliente",
            "Fecha de entrega",
            "Fecha de devolucion",
            "Multa"});
            this.cmbFiltro.Location = new System.Drawing.Point(522, 37);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(159, 24);
            this.cmbFiltro.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("NewsGoth Lt BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(442, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Buscar por:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.ForeColor = System.Drawing.Color.LightGray;
            this.txtFiltro.Location = new System.Drawing.Point(693, 37);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(279, 22);
            this.txtFiltro.TabIndex = 17;
            this.txtFiltro.Text = "Buscar...";
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Actualizar tabla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRentasActuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvRentas);
            this.MaximizeBox = false;
            this.Name = "frmRentasActuales";
            this.Text = "Rentas al momento";
            this.Load += new System.EventHandler(this.frmRentasActuales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRentas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeMaxVideoClubToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button button1;
    }
}