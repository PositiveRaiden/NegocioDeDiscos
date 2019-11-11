namespace Venta_de_discos.Formularios.Mantenimiento.ajusteDiscos
{
    partial class ModificarStock
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
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidadActual = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadNueva = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonSalirMenu = new System.Windows.Forms.Button();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Location = new System.Drawing.Point(12, 175);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(74, 13);
            this.lblStockMinimo.TabIndex = 72;
            this.lblStockMinimo.Text = "Stock Minimo:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(12, 105);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 71;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCantidadActual
            // 
            this.lblCantidadActual.AutoSize = true;
            this.lblCantidadActual.Location = new System.Drawing.Point(12, 140);
            this.lblCantidadActual.Name = "lblCantidadActual";
            this.lblCantidadActual.Size = new System.Drawing.Size(85, 13);
            this.lblCantidadActual.TabIndex = 69;
            this.lblCantidadActual.Text = "Cantidad Actual:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 13);
            this.lblNombre.TabIndex = 66;
            this.lblNombre.Text = "Nombre Álbum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Cantidad Nueva:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 33);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 15);
            this.lblFecha.TabIndex = 74;
            this.lblFecha.Text = "Fecha Actual:";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Descripción:";
            // 
            // txtCantidadNueva
            // 
            this.txtCantidadNueva.BackColor = System.Drawing.Color.White;
            this.txtCantidadNueva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCantidadNueva.Location = new System.Drawing.Point(268, 70);
            this.txtCantidadNueva.MaxLength = 5;
            this.txtCantidadNueva.Name = "txtCantidadNueva";
            this.txtCantidadNueva.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadNueva.TabIndex = 76;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDescripcion.Location = new System.Drawing.Point(268, 105);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(193, 20);
            this.txtDescripcion.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(332, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 78;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(413, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 79;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.botonSalirMenu);
            this.panel1.Controls.Add(this.lblOpciones);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 20);
            this.panel1.TabIndex = 80;
            // 
            // botonSalirMenu
            // 
            this.botonSalirMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botonSalirMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.botonSalirMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.botonSalirMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSalirMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonSalirMenu.Location = new System.Drawing.Point(480, 0);
            this.botonSalirMenu.Name = "botonSalirMenu";
            this.botonSalirMenu.Size = new System.Drawing.Size(20, 20);
            this.botonSalirMenu.TabIndex = 11;
            this.botonSalirMenu.Text = "X";
            this.botonSalirMenu.UseVisualStyleBackColor = false;
            this.botonSalirMenu.Click += new System.EventHandler(this.botonSalirMenu_Click);
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOpciones.Location = new System.Drawing.Point(12, 4);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(134, 13);
            this.lblOpciones.TabIndex = 8;
            this.lblOpciones.Text = "Modificacion de Stock";
            this.lblOpciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModificarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(500, 220);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCantidadNueva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStockMinimo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantidadActual);
            this.Controls.Add(this.lblNombre);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarStock";
            this.Text = "Modificar Stock";
            this.Load += new System.EventHandler(this.ModificarStock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidadActual;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadNueva;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonSalirMenu;
        private System.Windows.Forms.Label lblOpciones;
    }
}