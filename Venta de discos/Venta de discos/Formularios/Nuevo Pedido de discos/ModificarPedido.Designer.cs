namespace Venta_de_discos.Formularios.Nuevo_Pedido_de_discos
{
    partial class ModificarPedido
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
            this.filtroInterprete = new System.Windows.Forms.TextBox();
            this.filtroSello = new System.Windows.Forms.TextBox();
            this.filtroNombreAlbum = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id_Disco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblFechaHoy = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevoDisco = new System.Windows.Forms.Button();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.btnSalirMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtroInterprete
            // 
            this.filtroInterprete.Location = new System.Drawing.Point(271, 71);
            this.filtroInterprete.MaxLength = 30;
            this.filtroInterprete.Name = "filtroInterprete";
            this.filtroInterprete.Size = new System.Drawing.Size(100, 20);
            this.filtroInterprete.TabIndex = 53;
            this.filtroInterprete.TextChanged += new System.EventHandler(this.filtroInterprete_TextChanged);
            // 
            // filtroSello
            // 
            this.filtroSello.Location = new System.Drawing.Point(167, 71);
            this.filtroSello.MaxLength = 30;
            this.filtroSello.Name = "filtroSello";
            this.filtroSello.Size = new System.Drawing.Size(100, 20);
            this.filtroSello.TabIndex = 52;
            this.filtroSello.TextChanged += new System.EventHandler(this.filtroSello_TextChanged);
            // 
            // filtroNombreAlbum
            // 
            this.filtroNombreAlbum.Location = new System.Drawing.Point(61, 71);
            this.filtroNombreAlbum.MaxLength = 30;
            this.filtroNombreAlbum.Name = "filtroNombreAlbum";
            this.filtroNombreAlbum.Size = new System.Drawing.Size(100, 20);
            this.filtroNombreAlbum.TabIndex = 51;
            this.filtroNombreAlbum.TextChanged += new System.EventHandler(this.filtroNombreAlbum_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(386, 245);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(43, 37);
            this.btnEliminar.TabIndex = 50;
            this.btnEliminar.Text = "-";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(386, 202);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(43, 37);
            this.btnAgregar.TabIndex = 49;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Disco,
            this.NombreAlbum,
            this.Cantidad});
            this.dataGridView2.Location = new System.Drawing.Point(445, 97);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(300, 331);
            this.dataGridView2.TabIndex = 48;
            // 
            // id_Disco
            // 
            this.id_Disco.HeaderText = "id_Disco";
            this.id_Disco.Name = "id_Disco";
            this.id_Disco.Visible = false;
            // 
            // NombreAlbum
            // 
            this.NombreAlbum.HeaderText = "Nombre Album";
            this.NombreAlbum.Name = "NombreAlbum";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(346, 331);
            this.dataGridView1.TabIndex = 47;
            // 
            // LblFechaHoy
            // 
            this.LblFechaHoy.AutoSize = true;
            this.LblFechaHoy.ForeColor = System.Drawing.SystemColors.Control;
            this.LblFechaHoy.Location = new System.Drawing.Point(156, 23);
            this.LblFechaHoy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFechaHoy.Name = "LblFechaHoy";
            this.LblFechaHoy.Size = new System.Drawing.Size(0, 13);
            this.LblFechaHoy.TabIndex = 46;
            this.LblFechaHoy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.LblFecha.Location = new System.Drawing.Point(58, 23);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(37, 13);
            this.LblFecha.TabIndex = 45;
            this.LblFecha.Text = "Fecha";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(615, 446);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(534, 446);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 54;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevoDisco
            // 
            this.btnNuevoDisco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoDisco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoDisco.Location = new System.Drawing.Point(61, 42);
            this.btnNuevoDisco.Name = "btnNuevoDisco";
            this.btnNuevoDisco.Size = new System.Drawing.Size(82, 23);
            this.btnNuevoDisco.TabIndex = 56;
            this.btnNuevoDisco.Text = "Nuevo Disco";
            this.btnNuevoDisco.UseVisualStyleBackColor = true;
            this.btnNuevoDisco.Click += new System.EventHandler(this.btnNuevoDisco_Click);
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelBarra.Controls.Add(this.titulo);
            this.panelBarra.Controls.Add(this.btnSalirMenu);
            this.panelBarra.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(757, 20);
            this.panelBarra.TabIndex = 57;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titulo.Location = new System.Drawing.Point(14, 4);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(108, 13);
            this.titulo.TabIndex = 5;
            this.titulo.Text = "Modificar Pedidos";
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalirMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalirMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalirMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalirMenu.Location = new System.Drawing.Point(737, 0);
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(20, 20);
            this.btnSalirMenu.TabIndex = 4;
            this.btnSalirMenu.Text = "X";
            this.btnSalirMenu.UseVisualStyleBackColor = false;
            this.btnSalirMenu.Click += new System.EventHandler(this.btnSalirMenu_Click);
            // 
            // ModificarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(757, 475);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.btnNuevoDisco);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.filtroInterprete);
            this.Controls.Add(this.filtroSello);
            this.Controls.Add(this.filtroNombreAlbum);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblFechaHoy);
            this.Controls.Add(this.LblFecha);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarPedido";
            this.Load += new System.EventHandler(this.ModificarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filtroInterprete;
        private System.Windows.Forms.TextBox filtroSello;
        private System.Windows.Forms.TextBox filtroNombreAlbum;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblFechaHoy;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevoDisco;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Disco;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button btnSalirMenu;
    }
}