﻿namespace Venta_de_discos.Formularios.Mantenimiento
{
    partial class NuevoPais
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
            this.lblNuevoPais = new System.Windows.Forms.Label();
            this.txtNuevoPais = new System.Windows.Forms.TextBox();
            this.btnAceptarNuevoPais = new System.Windows.Forms.Button();
            this.btnSalirNuevoPais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNuevoPais
            // 
            this.lblNuevoPais.AutoSize = true;
            this.lblNuevoPais.Location = new System.Drawing.Point(25, 34);
            this.lblNuevoPais.Name = "lblNuevoPais";
            this.lblNuevoPais.Size = new System.Drawing.Size(47, 13);
            this.lblNuevoPais.TabIndex = 0;
            this.lblNuevoPais.Text = "Nombre:";
            // 
            // txtNuevoPais
            // 
            this.txtNuevoPais.Location = new System.Drawing.Point(90, 31);
            this.txtNuevoPais.MaxLength = 30;
            this.txtNuevoPais.Name = "txtNuevoPais";
            this.txtNuevoPais.Size = new System.Drawing.Size(200, 20);
            this.txtNuevoPais.TabIndex = 1;
            // 
            // btnAceptarNuevoPais
            // 
            this.btnAceptarNuevoPais.Location = new System.Drawing.Point(123, 79);
            this.btnAceptarNuevoPais.Name = "btnAceptarNuevoPais";
            this.btnAceptarNuevoPais.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarNuevoPais.TabIndex = 2;
            this.btnAceptarNuevoPais.Text = "Aceptar";
            this.btnAceptarNuevoPais.UseVisualStyleBackColor = true;
            this.btnAceptarNuevoPais.Click += new System.EventHandler(this.btnAceptarNuevoPais_Click);
            // 
            // btnSalirNuevoPais
            // 
            this.btnSalirNuevoPais.Location = new System.Drawing.Point(216, 79);
            this.btnSalirNuevoPais.Name = "btnSalirNuevoPais";
            this.btnSalirNuevoPais.Size = new System.Drawing.Size(75, 23);
            this.btnSalirNuevoPais.TabIndex = 3;
            this.btnSalirNuevoPais.Text = "Salir";
            this.btnSalirNuevoPais.UseVisualStyleBackColor = true;
            this.btnSalirNuevoPais.Click += new System.EventHandler(this.btnSalirNuevoPais_Click);
            // 
            // NuevoPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 116);
            this.Controls.Add(this.btnSalirNuevoPais);
            this.Controls.Add(this.btnAceptarNuevoPais);
            this.Controls.Add(this.txtNuevoPais);
            this.Controls.Add(this.lblNuevoPais);
            this.Name = "NuevoPais";
            this.Text = "Nuevo País";
            this.Load += new System.EventHandler(this.NuevoPais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoPais;
        private System.Windows.Forms.TextBox txtNuevoPais;
        private System.Windows.Forms.Button btnAceptarNuevoPais;
        private System.Windows.Forms.Button btnSalirNuevoPais;
    }
}