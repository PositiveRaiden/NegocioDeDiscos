namespace Venta_de_discos
{
    partial class MenuMantenimiento
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
            this.lblOpciones = new System.Windows.Forms.Label();
            this.btnSalirMenu = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnVentaDeDiscos = new System.Windows.Forms.Button();
            this.btnGeneros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBarrio = new System.Windows.Forms.Button();
            this.btnSello = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnAjuste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Location = new System.Drawing.Point(128, 9);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(131, 13);
            this.lblOpciones.TabIndex = 8;
            this.lblOpciones.Text = "Mantenimiento del sistema";
            this.lblOpciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.Location = new System.Drawing.Point(308, 252);
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(75, 23);
            this.btnSalirMenu.TabIndex = 7;
            this.btnSalirMenu.Text = "Salir";
            this.btnSalirMenu.UseVisualStyleBackColor = true;
            this.btnSalirMenu.Click += new System.EventHandler(this.btnSalirMenu_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Location = new System.Drawing.Point(12, 221);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(134, 24);
            this.btnInformes.TabIndex = 5;
            this.btnInformes.Text = "Nacionalidad";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnVentaDeDiscos
            // 
            this.btnVentaDeDiscos.Location = new System.Drawing.Point(12, 191);
            this.btnVentaDeDiscos.Name = "btnVentaDeDiscos";
            this.btnVentaDeDiscos.Size = new System.Drawing.Size(134, 23);
            this.btnVentaDeDiscos.TabIndex = 4;
            this.btnVentaDeDiscos.Text = "Intérprete";
            this.btnVentaDeDiscos.UseVisualStyleBackColor = true;
            this.btnVentaDeDiscos.Click += new System.EventHandler(this.btnVentaDeDiscos_Click);
            // 
            // btnGeneros
            // 
            this.btnGeneros.Location = new System.Drawing.Point(12, 162);
            this.btnGeneros.Name = "btnGeneros";
            this.btnGeneros.Size = new System.Drawing.Size(134, 23);
            this.btnGeneros.TabIndex = 3;
            this.btnGeneros.Text = "Género ";
            this.btnGeneros.UseVisualStyleBackColor = true;
            this.btnGeneros.Click += new System.EventHandler(this.btnGeneros_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccione opción deseada:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBarrio
            // 
            this.btnBarrio.Location = new System.Drawing.Point(12, 104);
            this.btnBarrio.Name = "btnBarrio";
            this.btnBarrio.Size = new System.Drawing.Size(134, 23);
            this.btnBarrio.TabIndex = 1;
            this.btnBarrio.Text = "Barrio";
            this.btnBarrio.UseVisualStyleBackColor = true;
            this.btnBarrio.Click += new System.EventHandler(this.btnBarrio_Click);
            // 
            // btnSello
            // 
            this.btnSello.Location = new System.Drawing.Point(12, 252);
            this.btnSello.Name = "btnSello";
            this.btnSello.Size = new System.Drawing.Size(134, 23);
            this.btnSello.TabIndex = 6;
            this.btnSello.Text = "Sello Discografico";
            this.btnSello.UseVisualStyleBackColor = true;
            this.btnSello.Click += new System.EventHandler(this.btnSello_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(12, 133);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(134, 23);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnAjuste
            // 
            this.btnAjuste.Location = new System.Drawing.Point(12, 75);
            this.btnAjuste.Name = "btnAjuste";
            this.btnAjuste.Size = new System.Drawing.Size(134, 23);
            this.btnAjuste.TabIndex = 0;
            this.btnAjuste.Text = "Ajuste Discos";
            this.btnAjuste.UseVisualStyleBackColor = true;
            this.btnAjuste.Click += new System.EventHandler(this.btnAjuste_Click);
            // 
            // MenuMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 286);
            this.Controls.Add(this.btnAjuste);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnSello);
            this.Controls.Add(this.btnBarrio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeneros);
            this.Controls.Add(this.btnVentaDeDiscos);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.btnSalirMenu);
            this.Name = "MenuMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Mantenimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button btnSalirMenu;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnVentaDeDiscos;
        private System.Windows.Forms.Button btnGeneros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBarrio;
        private System.Windows.Forms.Button btnSello;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnAjuste;
    }
}