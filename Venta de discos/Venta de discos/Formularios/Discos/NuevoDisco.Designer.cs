﻿namespace Venta_de_discos
{
    partial class AgregarDisco
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreAlbum = new System.Windows.Forms.TextBox();
            this.txtAñoEdicion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbSello = new System.Windows.Forms.ComboBox();
            this.cmbInterprete = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Intérprete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Álbum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Género";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sello Discográfico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(250, 315);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Año Edición";
            // 
            // txtNombreAlbum
            // 
            this.txtNombreAlbum.Location = new System.Drawing.Point(143, 23);
            this.txtNombreAlbum.MaxLength = 30;
            this.txtNombreAlbum.Name = "txtNombreAlbum";
            this.txtNombreAlbum.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAlbum.TabIndex = 10;
            // 
            // txtAñoEdicion
            // 
            this.txtAñoEdicion.Location = new System.Drawing.Point(144, 166);
            this.txtAñoEdicion.MaxLength = 4;
            this.txtAñoEdicion.Name = "txtAñoEdicion";
            this.txtAñoEdicion.Size = new System.Drawing.Size(100, 20);
            this.txtAñoEdicion.TabIndex = 13;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(144, 201);
            this.txtCantidad.MaxLength = 4;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 14;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(331, 315);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(144, 91);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(100, 21);
            this.cmbGenero.TabIndex = 34;
            // 
            // cmbSello
            // 
            this.cmbSello.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSello.FormattingEnabled = true;
            this.cmbSello.Location = new System.Drawing.Point(144, 129);
            this.cmbSello.Name = "cmbSello";
            this.cmbSello.Size = new System.Drawing.Size(100, 21);
            this.cmbSello.TabIndex = 35;
            // 
            // cmbInterprete
            // 
            this.cmbInterprete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterprete.FormattingEnabled = true;
            this.cmbInterprete.Location = new System.Drawing.Point(144, 56);
            this.cmbInterprete.Name = "cmbInterprete";
            this.cmbInterprete.Size = new System.Drawing.Size(100, 21);
            this.cmbInterprete.TabIndex = 36;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(44, 239);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 37;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(144, 236);
            this.txtPrecio.MaxLength = 10;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 38;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 21);
            this.button1.TabIndex = 39;
            this.button1.Text = "Nuevo Interprete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 21);
            this.button2.TabIndex = 40;
            this.button2.Text = "Nuevo Genero";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 21);
            this.button3.TabIndex = 41;
            this.button3.Text = "Nuevo Sello";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(144, 271);
            this.txtStock.MaxLength = 10;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 42;
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Location = new System.Drawing.Point(44, 274);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(71, 13);
            this.lblStockMinimo.TabIndex = 43;
            this.lblStockMinimo.Text = "Stock Minimo";
            // 
            // AgregarDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 350);
            this.Controls.Add(this.lblStockMinimo);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cmbInterprete);
            this.Controls.Add(this.cmbSello);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtAñoEdicion);
            this.Controls.Add(this.txtNombreAlbum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AgregarDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Disco";
            this.Load += new System.EventHandler(this.AgregarDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreAlbum;
        private System.Windows.Forms.TextBox txtAñoEdicion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbSello;
        private System.Windows.Forms.ComboBox cmbInterprete;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.TextBox txtStock;
    }
}