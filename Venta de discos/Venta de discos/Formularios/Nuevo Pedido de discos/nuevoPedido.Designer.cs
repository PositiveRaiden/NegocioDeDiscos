namespace Venta_de_discos.Formularios.Nuevo_Pedido_de_discos
{
    partial class NuevoPedido
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
            this.LblFechaHoy = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoEdicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelloDiscografico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interprete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filtroNombreAlbum = new System.Windows.Forms.TextBox();
            this.filtroSello = new System.Windows.Forms.TextBox();
            this.filtroInterprete = new System.Windows.Forms.TextBox();
            this.btnNuevoDisco = new System.Windows.Forms.Button();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.btnSalirMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblFechaHoy
            // 
            this.LblFechaHoy.AutoSize = true;
            this.LblFechaHoy.Location = new System.Drawing.Point(143, 27);
            this.LblFechaHoy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFechaHoy.Name = "LblFechaHoy";
            this.LblFechaHoy.Size = new System.Drawing.Size(0, 13);
            this.LblFechaHoy.TabIndex = 32;
            this.LblFechaHoy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblFecha.Location = new System.Drawing.Point(45, 27);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(37, 13);
            this.LblFecha.TabIndex = 31;
            this.LblFecha.Text = "Fecha";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblFecha.Click += new System.EventHandler(this.LblFecha_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NombreAlbum,
            this.Cantidad,
            this.Precio,
            this.AñoEdicion,
            this.Genero,
            this.SelloDiscografico,
            this.Interprete});
            this.dataGridView2.Location = new System.Drawing.Point(432, 101);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(245, 331);
            this.dataGridView2.TabIndex = 37;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // NombreAlbum
            // 
            this.NombreAlbum.HeaderText = "Nombre Album";
            this.NombreAlbum.Name = "NombreAlbum";
            this.NombreAlbum.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Visible = false;
            // 
            // AñoEdicion
            // 
            this.AñoEdicion.HeaderText = "Año Edicion";
            this.AñoEdicion.Name = "AñoEdicion";
            this.AñoEdicion.ReadOnly = true;
            this.AñoEdicion.Visible = false;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Visible = false;
            // 
            // SelloDiscografico
            // 
            this.SelloDiscografico.HeaderText = "Sello Discografico";
            this.SelloDiscografico.Name = "SelloDiscografico";
            this.SelloDiscografico.ReadOnly = true;
            this.SelloDiscografico.Visible = false;
            // 
            // Interprete
            // 
            this.Interprete.HeaderText = "Interprete";
            this.Interprete.Name = "Interprete";
            this.Interprete.ReadOnly = true;
            this.Interprete.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.Location = new System.Drawing.Point(521, 449);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 38;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(602, 449);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(373, 206);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(43, 37);
            this.btnAgregar.TabIndex = 40;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(373, 249);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(43, 37);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "-";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(346, 331);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // filtroNombreAlbum
            // 
            this.filtroNombreAlbum.Location = new System.Drawing.Point(48, 75);
            this.filtroNombreAlbum.Name = "filtroNombreAlbum";
            this.filtroNombreAlbum.Size = new System.Drawing.Size(100, 20);
            this.filtroNombreAlbum.TabIndex = 42;
            this.filtroNombreAlbum.TextChanged += new System.EventHandler(this.filtroNombreAlbum_TextChanged);
            // 
            // filtroSello
            // 
            this.filtroSello.Location = new System.Drawing.Point(154, 75);
            this.filtroSello.Name = "filtroSello";
            this.filtroSello.Size = new System.Drawing.Size(100, 20);
            this.filtroSello.TabIndex = 43;
            this.filtroSello.TextChanged += new System.EventHandler(this.filtroSello_TextChanged);
            // 
            // filtroInterprete
            // 
            this.filtroInterprete.Location = new System.Drawing.Point(258, 75);
            this.filtroInterprete.Name = "filtroInterprete";
            this.filtroInterprete.Size = new System.Drawing.Size(100, 20);
            this.filtroInterprete.TabIndex = 44;
            this.filtroInterprete.TextChanged += new System.EventHandler(this.filtroInterprete_TextChanged);
            // 
            // btnNuevoDisco
            // 
            this.btnNuevoDisco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoDisco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevoDisco.Location = new System.Drawing.Point(48, 46);
            this.btnNuevoDisco.Name = "btnNuevoDisco";
            this.btnNuevoDisco.Size = new System.Drawing.Size(82, 23);
            this.btnNuevoDisco.TabIndex = 45;
            this.btnNuevoDisco.Text = "Nuevo Disco";
            this.btnNuevoDisco.UseVisualStyleBackColor = true;
            this.btnNuevoDisco.Click += new System.EventHandler(this.btnNuevoDisco_Click);
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelBarra.Controls.Add(this.titulo);
            this.panelBarra.Controls.Add(this.btnSalirMenu);
            this.panelBarra.ForeColor = System.Drawing.SystemColors.Control;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(702, 20);
            this.panelBarra.TabIndex = 46;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(14, 4);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(100, 13);
            this.titulo.TabIndex = 5;
            this.titulo.Text = "Agregar Pedidos";
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalirMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalirMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalirMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalirMenu.Location = new System.Drawing.Point(682, 0);
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(20, 20);
            this.btnSalirMenu.TabIndex = 4;
            this.btnSalirMenu.Text = "X";
            this.btnSalirMenu.UseVisualStyleBackColor = false;
            this.btnSalirMenu.Click += new System.EventHandler(this.btnSalirMenu_Click);
            // 
            // NuevoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(702, 485);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.btnNuevoDisco);
            this.Controls.Add(this.filtroInterprete);
            this.Controls.Add(this.filtroSello);
            this.Controls.Add(this.filtroNombreAlbum);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblFechaHoy);
            this.Controls.Add(this.LblFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoPedido";
            this.Load += new System.EventHandler(this.NuevoPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblFechaHoy;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoEdicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelloDiscografico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interprete;
        private System.Windows.Forms.TextBox filtroNombreAlbum;
        private System.Windows.Forms.TextBox filtroSello;
        private System.Windows.Forms.TextBox filtroInterprete;
        private System.Windows.Forms.Button btnNuevoDisco;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button btnSalirMenu;
    }
}