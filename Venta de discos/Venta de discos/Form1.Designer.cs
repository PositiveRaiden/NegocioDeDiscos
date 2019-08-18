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
            this.btnAdministracionDiscos = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnVentaDeDiscos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.Location = new System.Drawing.Point(336, 226);
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(75, 23);
            this.btnSalirMenu.TabIndex = 0;
            this.btnSalirMenu.Text = "Salir";
            this.btnSalirMenu.UseVisualStyleBackColor = true;
            this.btnSalirMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Location = new System.Drawing.Point(138, 33);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(119, 13);
            this.lblOpciones.TabIndex = 1;
            this.lblOpciones.Text = "Seleccione una opción:";
            this.lblOpciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdministracionDiscos
            // 
            this.btnAdministracionDiscos.Location = new System.Drawing.Point(141, 66);
            this.btnAdministracionDiscos.Name = "btnAdministracionDiscos";
            this.btnAdministracionDiscos.Size = new System.Drawing.Size(116, 23);
            this.btnAdministracionDiscos.TabIndex = 2;
            this.btnAdministracionDiscos.Text = "Gestión de discos";
            this.btnAdministracionDiscos.UseVisualStyleBackColor = true;
            // 
            // btnInformes
            // 
            this.btnInformes.Location = new System.Drawing.Point(141, 148);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(116, 23);
            this.btnInformes.TabIndex = 3;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            // 
            // btnVentaDeDiscos
            // 
            this.btnVentaDeDiscos.Location = new System.Drawing.Point(141, 108);
            this.btnVentaDeDiscos.Name = "btnVentaDeDiscos";
            this.btnVentaDeDiscos.Size = new System.Drawing.Size(116, 23);
            this.btnVentaDeDiscos.TabIndex = 4;
            this.btnVentaDeDiscos.Text = "Generar venta";
            this.btnVentaDeDiscos.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 261);
            this.Controls.Add(this.btnVentaDeDiscos);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.btnAdministracionDiscos);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.btnSalirMenu);
            this.Name = "frmMenu";
            this.Text = "Menú gestión negocio de discos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirMenu;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button btnAdministracionDiscos;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnVentaDeDiscos;
    }
}

