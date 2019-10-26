namespace Venta_de_discos.Formularios.Nueva_Venta
{
    partial class ModificarVenta
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
            this.btnNuevoDisco = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.filtroInterprete = new System.Windows.Forms.TextBox();
            this.filtroSello = new System.Windows.Forms.TextBox();
            this.filtroNombreAlbum = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblFechaHoy = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoEdicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelloDiscografico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interprete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoDisco
            // 
            this.btnNuevoDisco.Location = new System.Drawing.Point(17, 442);
            this.btnNuevoDisco.Name = "btnNuevoDisco";
            this.btnNuevoDisco.Size = new System.Drawing.Size(82, 23);
            this.btnNuevoDisco.TabIndex = 68;
            this.btnNuevoDisco.Text = "Nuevo Disco";
            this.btnNuevoDisco.UseVisualStyleBackColor = true;
            this.btnNuevoDisco.Click += new System.EventHandler(this.btnNuevoDisco_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(803, 442);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 67;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(722, 442);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 66;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // filtroInterprete
            // 
            this.filtroInterprete.Location = new System.Drawing.Point(260, 82);
            this.filtroInterprete.MaxLength = 30;
            this.filtroInterprete.Name = "filtroInterprete";
            this.filtroInterprete.Size = new System.Drawing.Size(90, 20);
            this.filtroInterprete.TabIndex = 65;
            this.filtroInterprete.TextChanged += new System.EventHandler(this.filtroInterprete_TextChanged);
            // 
            // filtroSello
            // 
            this.filtroSello.Location = new System.Drawing.Point(157, 82);
            this.filtroSello.MaxLength = 30;
            this.filtroSello.Name = "filtroSello";
            this.filtroSello.Size = new System.Drawing.Size(108, 20);
            this.filtroSello.TabIndex = 64;
            this.filtroSello.TextChanged += new System.EventHandler(this.filtroSello_TextChanged);
            // 
            // filtroNombreAlbum
            // 
            this.filtroNombreAlbum.Location = new System.Drawing.Point(57, 82);
            this.filtroNombreAlbum.MaxLength = 30;
            this.filtroNombreAlbum.Name = "filtroNombreAlbum";
            this.filtroNombreAlbum.Size = new System.Drawing.Size(103, 20);
            this.filtroNombreAlbum.TabIndex = 63;
            this.filtroNombreAlbum.TextChanged += new System.EventHandler(this.filtroNombreAlbum_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(404, 252);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(43, 37);
            this.btnEliminar.TabIndex = 62;
            this.btnEliminar.Text = "-";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(404, 209);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(43, 37);
            this.btnAgregar.TabIndex = 61;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 105);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(381, 331);
            this.dataGridView1.TabIndex = 59;
            // 
            // LblFechaHoy
            // 
            this.LblFechaHoy.AutoSize = true;
            this.LblFechaHoy.Location = new System.Drawing.Point(54, 53);
            this.LblFechaHoy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFechaHoy.Name = "LblFechaHoy";
            this.LblFechaHoy.Size = new System.Drawing.Size(74, 13);
            this.LblFechaHoy.TabIndex = 58;
            this.LblFechaHoy.Text = "venta invisible";
            this.LblFechaHoy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(11, 53);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(40, 13);
            this.LblFecha.TabIndex = 57;
            this.LblFecha.Text = "Fecha:";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Discos vendidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Filtrar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(14, 22);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 13);
            this.lblCliente.TabIndex = 71;
            this.lblCliente.Text = "Cliente: ";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(526, 444);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 73;
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Location = new System.Drawing.Point(450, 447);
            this.lblImporteTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(71, 13);
            this.lblImporteTotal.TabIndex = 72;
            this.lblImporteTotal.Text = "Importe total: ";
            this.lblImporteTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NombreAlbum,
            this.Precio,
            this.AñoEdicion,
            this.Cantidad,
            this.Genero,
            this.SelloDiscografico,
            this.Interprete,
            this.subtotal});
            this.dgvVentas.Location = new System.Drawing.Point(453, 101);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvVentas.Size = new System.Drawing.Size(425, 331);
            this.dgvVentas.TabIndex = 74;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            this.dgvVentas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellEndEdit);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // NombreAlbum
            // 
            this.NombreAlbum.HeaderText = "Nombre Álbum";
            this.NombreAlbum.Name = "NombreAlbum";
            this.NombreAlbum.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // AñoEdicion
            // 
            this.AñoEdicion.HeaderText = "Año Edicion";
            this.AñoEdicion.Name = "AñoEdicion";
            this.AñoEdicion.ReadOnly = true;
            this.AñoEdicion.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Género";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Visible = false;
            // 
            // SelloDiscografico
            // 
            this.SelloDiscografico.HeaderText = "Sello Discográfico";
            this.SelloDiscografico.Name = "SelloDiscografico";
            this.SelloDiscografico.ReadOnly = true;
            this.SelloDiscografico.Visible = false;
            // 
            // Interprete
            // 
            this.Interprete.HeaderText = "Intérprete";
            this.Interprete.Name = "Interprete";
            this.Interprete.ReadOnly = true;
            this.Interprete.Visible = false;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            // 
            // ModificarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 490);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblImporteTotal);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevoDisco);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.filtroInterprete);
            this.Controls.Add(this.filtroSello);
            this.Controls.Add(this.filtroNombreAlbum);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblFechaHoy);
            this.Controls.Add(this.LblFecha);
            this.Name = "ModificarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarVenta";
            this.Load += new System.EventHandler(this.ModificarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoDisco;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox filtroInterprete;
        private System.Windows.Forms.TextBox filtroSello;
        private System.Windows.Forms.TextBox filtroNombreAlbum;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblFechaHoy;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoEdicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelloDiscografico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interprete;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}