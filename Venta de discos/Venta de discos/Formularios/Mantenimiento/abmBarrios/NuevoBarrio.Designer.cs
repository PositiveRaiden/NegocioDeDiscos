namespace Venta_de_discos.Formularios.Mantenimiento
{
    partial class NuevoBarrio
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
            this.btnSalirNuevoPais = new System.Windows.Forms.Button();
            this.btnAceptarNuevoPais = new System.Windows.Forms.Button();
            this.txtNuevoPais = new System.Windows.Forms.TextBox();
            this.lblNuevoPais = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalirNuevoPais
            // 
            this.btnSalirNuevoPais.Location = new System.Drawing.Point(158, 78);
            this.btnSalirNuevoPais.Name = "btnSalirNuevoPais";
            this.btnSalirNuevoPais.Size = new System.Drawing.Size(75, 23);
            this.btnSalirNuevoPais.TabIndex = 7;
            this.btnSalirNuevoPais.Text = "Salir";
            this.btnSalirNuevoPais.UseVisualStyleBackColor = true;
            this.btnSalirNuevoPais.Click += new System.EventHandler(this.btnSalirNuevoPais_Click);
            // 
            // btnAceptarNuevoPais
            // 
            this.btnAceptarNuevoPais.Location = new System.Drawing.Point(65, 78);
            this.btnAceptarNuevoPais.Name = "btnAceptarNuevoPais";
            this.btnAceptarNuevoPais.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarNuevoPais.TabIndex = 6;
            this.btnAceptarNuevoPais.Text = "Guardar";
            this.btnAceptarNuevoPais.UseVisualStyleBackColor = true;
            // 
            // txtNuevoPais
            // 
            this.txtNuevoPais.Location = new System.Drawing.Point(65, 19);
            this.txtNuevoPais.Name = "txtNuevoPais";
            this.txtNuevoPais.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoPais.TabIndex = 5;
            // 
            // lblNuevoPais
            // 
            this.lblNuevoPais.AutoSize = true;
            this.lblNuevoPais.Location = new System.Drawing.Point(12, 26);
            this.lblNuevoPais.Name = "lblNuevoPais";
            this.lblNuevoPais.Size = new System.Drawing.Size(47, 13);
            this.lblNuevoPais.TabIndex = 4;
            this.lblNuevoPais.Text = "Nombre:";
            // 
            // NuevoBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 125);
            this.Controls.Add(this.btnSalirNuevoPais);
            this.Controls.Add(this.btnAceptarNuevoPais);
            this.Controls.Add(this.txtNuevoPais);
            this.Controls.Add(this.lblNuevoPais);
            this.Name = "NuevoBarrio";
            this.Text = "NuevoBarrio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirNuevoPais;
        private System.Windows.Forms.Button btnAceptarNuevoPais;
        private System.Windows.Forms.TextBox txtNuevoPais;
        private System.Windows.Forms.Label lblNuevoPais;
    }
}