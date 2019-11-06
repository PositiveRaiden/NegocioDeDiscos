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
            this.btnSalirMenu = new System.Windows.Forms.Button();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.btnDiscos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.Location = new System.Drawing.Point(307, 229);
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(75, 23);
            this.btnSalirMenu.TabIndex = 4;
            this.btnSalirMenu.Text = "Salir";
            this.btnSalirMenu.UseVisualStyleBackColor = true;
            this.btnSalirMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Location = new System.Drawing.Point(129, 33);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(119, 13);
            this.lblOpciones.TabIndex = 1;
            this.lblOpciones.Text = "Seleccione una opción:";
            this.lblOpciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.Location = new System.Drawing.Point(123, 181);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(134, 24);
            this.btnMantenimiento.TabIndex = 3;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Location = new System.Drawing.Point(123, 142);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(134, 23);
            this.btnNuevaVenta.TabIndex = 2;
            this.btnNuevaVenta.Text = "Venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnVentaDeDiscos_Click);
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.Location = new System.Drawing.Point(123, 103);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(134, 23);
            this.btnNuevoPedido.TabIndex = 1;
            this.btnNuevoPedido.Text = "Pedido";
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // btnDiscos
            // 
            this.btnDiscos.Location = new System.Drawing.Point(123, 64);
            this.btnDiscos.Name = "btnDiscos";
            this.btnDiscos.Size = new System.Drawing.Size(134, 23);
            this.btnDiscos.TabIndex = 0;
            this.btnDiscos.Text = "Discos";
            this.btnDiscos.UseVisualStyleBackColor = true;
            this.btnDiscos.Click += new System.EventHandler(this.btnBuscarDisco_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reportes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 255);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDiscos);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.btnNuevaVenta);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.btnSalirMenu);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Negocio Venta de Discos";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirMenu;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnDiscos;
        private System.Windows.Forms.Button button1;
    }
}

