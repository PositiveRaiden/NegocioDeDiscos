namespace Venta_de_discos
{
    partial class frmInformes
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
            this.btnSalirInformes = new System.Windows.Forms.Button();
            this.btnInformeDiscos = new System.Windows.Forms.Button();
            this.btnInformeVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalirInformes
            // 
            this.btnSalirInformes.Location = new System.Drawing.Point(138, 110);
            this.btnSalirInformes.Name = "btnSalirInformes";
            this.btnSalirInformes.Size = new System.Drawing.Size(75, 23);
            this.btnSalirInformes.TabIndex = 1;
            this.btnSalirInformes.Text = "Salir";
            this.btnSalirInformes.UseVisualStyleBackColor = true;
            // 
            // btnInformeDiscos
            // 
            this.btnInformeDiscos.Location = new System.Drawing.Point(44, 38);
            this.btnInformeDiscos.Name = "btnInformeDiscos";
            this.btnInformeDiscos.Size = new System.Drawing.Size(132, 23);
            this.btnInformeDiscos.TabIndex = 2;
            this.btnInformeDiscos.Text = "Listado de discos";
            this.btnInformeDiscos.UseVisualStyleBackColor = true;
            // 
            // btnInformeVentas
            // 
            this.btnInformeVentas.Location = new System.Drawing.Point(44, 67);
            this.btnInformeVentas.Name = "btnInformeVentas";
            this.btnInformeVentas.Size = new System.Drawing.Size(132, 23);
            this.btnInformeVentas.TabIndex = 3;
            this.btnInformeVentas.Text = "Ventas del mes";
            this.btnInformeVentas.UseVisualStyleBackColor = true;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 145);
            this.Controls.Add(this.btnInformeVentas);
            this.Controls.Add(this.btnInformeDiscos);
            this.Controls.Add(this.btnSalirInformes);
            this.Name = "frmInformes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Informes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalirInformes;
        private System.Windows.Forms.Button btnInformeDiscos;
        private System.Windows.Forms.Button btnInformeVentas;
    }
}