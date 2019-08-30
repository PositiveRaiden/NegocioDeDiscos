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
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnVentaDeDiscos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscarDisco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.Location = new System.Drawing.Point(297, 248);
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
            // btnInformes
            // 
            this.btnInformes.Location = new System.Drawing.Point(123, 182);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(134, 24);
            this.btnInformes.TabIndex = 3;
            this.btnInformes.Text = "Mantenimiento";
            this.btnInformes.UseVisualStyleBackColor = true;
            // 
            // btnVentaDeDiscos
            // 
            this.btnVentaDeDiscos.Location = new System.Drawing.Point(123, 144);
            this.btnVentaDeDiscos.Name = "btnVentaDeDiscos";
            this.btnVentaDeDiscos.Size = new System.Drawing.Size(134, 23);
            this.btnVentaDeDiscos.TabIndex = 2;
            this.btnVentaDeDiscos.Text = "Nueva Venta";
            this.btnVentaDeDiscos.UseVisualStyleBackColor = true;
            this.btnVentaDeDiscos.Click += new System.EventHandler(this.btnVentaDeDiscos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Nuevo Pedido";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBuscarDisco
            // 
            this.btnBuscarDisco.Location = new System.Drawing.Point(123, 64);
            this.btnBuscarDisco.Name = "btnBuscarDisco";
            this.btnBuscarDisco.Size = new System.Drawing.Size(134, 23);
            this.btnBuscarDisco.TabIndex = 7;
            this.btnBuscarDisco.Text = "Discos";
            this.btnBuscarDisco.UseVisualStyleBackColor = true;
            this.btnBuscarDisco.Click += new System.EventHandler(this.btnBuscarDisco_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 283);
            this.Controls.Add(this.btnBuscarDisco);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVentaDeDiscos);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.btnSalirMenu);
            this.Name = "frmMenu";
            this.Text = "n";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirMenu;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnVentaDeDiscos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscarDisco;
    }
}

