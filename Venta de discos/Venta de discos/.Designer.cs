namespace Venta_de_discos
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblOpciones = new System.Windows.Forms.Label();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.btnDiscos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalirMenu = new System.Windows.Forms.Button();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.BackColor = System.Drawing.Color.Transparent;
            this.lblOpciones.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.ForeColor = System.Drawing.Color.Transparent;
            this.lblOpciones.Location = new System.Drawing.Point(30, 3);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(156, 33);
            this.lblOpciones.TabIndex = 1;
            this.lblOpciones.Text = "Gestor de Discos";
            this.lblOpciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMantenimiento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMantenimiento.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMantenimiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnMantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimiento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMantenimiento.Location = new System.Drawing.Point(207, 44);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(90, 23);
            this.btnMantenimiento.TabIndex = 3;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevaVenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevaVenta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNuevaVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnNuevaVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevaVenta.Location = new System.Drawing.Point(207, 15);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(90, 23);
            this.btnNuevaVenta.TabIndex = 2;
            this.btnNuevaVenta.Text = "Venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = false;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnVentaDeDiscos_Click);
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevoPedido.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoPedido.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNuevoPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnNuevoPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPedido.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevoPedido.Location = new System.Drawing.Point(207, 103);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(90, 23);
            this.btnNuevoPedido.TabIndex = 1;
            this.btnNuevoPedido.Text = "Pedido";
            this.btnNuevoPedido.UseVisualStyleBackColor = false;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // btnDiscos
            // 
            this.btnDiscos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDiscos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDiscos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDiscos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnDiscos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDiscos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDiscos.Location = new System.Drawing.Point(207, 132);
            this.btnDiscos.Name = "btnDiscos";
            this.btnDiscos.Size = new System.Drawing.Size(90, 23);
            this.btnDiscos.TabIndex = 0;
            this.btnDiscos.Text = "Discos";
            this.btnDiscos.UseVisualStyleBackColor = false;
            this.btnDiscos.Click += new System.EventHandler(this.btnBuscarDisco_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(207, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reportes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalirMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalirMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalirMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalirMenu.Location = new System.Drawing.Point(280, 0);
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(20, 20);
            this.btnSalirMenu.TabIndex = 4;
            this.btnSalirMenu.Text = "X";
            this.btnSalirMenu.UseVisualStyleBackColor = false;
            this.btnSalirMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelBarra.Controls.Add(this.titulo);
            this.panelBarra.Controls.Add(this.btnSalirMenu);
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(300, 20);
            this.panelBarra.TabIndex = 6;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(14, 4);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(157, 13);
            this.titulo.TabIndex = 5;
            this.titulo.Text = "Menu de Gestion de Dicos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.btnNuevaVenta);
            this.panelContenido.Controls.Add(this.pictureBox1);
            this.panelContenido.Controls.Add(this.lblOpciones);
            this.panelContenido.Controls.Add(this.btnMantenimiento);
            this.panelContenido.Controls.Add(this.button1);
            this.panelContenido.Controls.Add(this.btnNuevoPedido);
            this.panelContenido.Controls.Add(this.btnDiscos);
            this.panelContenido.Location = new System.Drawing.Point(0, 20);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(300, 170);
            this.panelContenido.TabIndex = 8;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(300, 190);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelBarra);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Negocio Venta de Discos";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnDiscos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalirMenu;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContenido;
    }
}

