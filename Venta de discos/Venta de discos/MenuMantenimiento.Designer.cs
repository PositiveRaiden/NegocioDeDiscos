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
            this.SuspendLayout();
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Location = new System.Drawing.Point(128, 9);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(131, 13);
            this.lblOpciones.TabIndex = 7;
            this.lblOpciones.Text = "Mantenimiento del sistema";
            this.lblOpciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.Location = new System.Drawing.Point(305, 238);
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(75, 23);
            this.btnSalirMenu.TabIndex = 10;
            this.btnSalirMenu.Text = "Salir";
            this.btnSalirMenu.UseVisualStyleBackColor = true;
            this.btnSalirMenu.Click += new System.EventHandler(this.btnSalirMenu_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Location = new System.Drawing.Point(15, 148);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(134, 24);
            this.btnInformes.TabIndex = 2;
            this.btnInformes.Text = "Nacionalidad";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnVentaDeDiscos
            // 
            this.btnVentaDeDiscos.Location = new System.Drawing.Point(15, 119);
            this.btnVentaDeDiscos.Name = "btnVentaDeDiscos";
            this.btnVentaDeDiscos.Size = new System.Drawing.Size(134, 23);
            this.btnVentaDeDiscos.TabIndex = 1;
            this.btnVentaDeDiscos.Text = "Intérprete";
            this.btnVentaDeDiscos.UseVisualStyleBackColor = true;
            this.btnVentaDeDiscos.Click += new System.EventHandler(this.btnVentaDeDiscos_Click);
            // 
            // btnGeneros
            // 
            this.btnGeneros.Location = new System.Drawing.Point(15, 90);
            this.btnGeneros.Name = "btnGeneros";
            this.btnGeneros.Size = new System.Drawing.Size(134, 23);
            this.btnGeneros.TabIndex = 0;
            this.btnGeneros.Text = "Género ";
            this.btnGeneros.UseVisualStyleBackColor = true;
            this.btnGeneros.Click += new System.EventHandler(this.btnGeneros_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccione que desea modificar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBarrio
            // 
            this.btnBarrio.Location = new System.Drawing.Point(15, 178);
            this.btnBarrio.Name = "btnBarrio";
            this.btnBarrio.Size = new System.Drawing.Size(134, 23);
            this.btnBarrio.TabIndex = 13;
            this.btnBarrio.Text = "Barrio";
            this.btnBarrio.UseVisualStyleBackColor = true;
            this.btnBarrio.Click += new System.EventHandler(this.btnBarrio_Click);
            // 
            // MenuMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 283);
            this.Controls.Add(this.btnBarrio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeneros);
            this.Controls.Add(this.btnVentaDeDiscos);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.btnSalirMenu);
            this.Name = "MenuMantenimiento";
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
    }
}