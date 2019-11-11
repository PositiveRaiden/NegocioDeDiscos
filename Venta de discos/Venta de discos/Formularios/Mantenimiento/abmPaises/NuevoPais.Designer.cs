namespace Venta_de_discos.Formularios.Mantenimiento
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
            this.panelBarra = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.btnSalirMenu = new System.Windows.Forms.Button();
            this.panelBarra.SuspendLayout();
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
            this.btnAceptarNuevoPais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAceptarNuevoPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarNuevoPais.Location = new System.Drawing.Point(122, 67);
            this.btnAceptarNuevoPais.Name = "btnAceptarNuevoPais";
            this.btnAceptarNuevoPais.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarNuevoPais.TabIndex = 2;
            this.btnAceptarNuevoPais.Text = "Aceptar";
            this.btnAceptarNuevoPais.UseVisualStyleBackColor = true;
            this.btnAceptarNuevoPais.Click += new System.EventHandler(this.btnAceptarNuevoPais_Click);
            // 
            // btnSalirNuevoPais
            // 
            this.btnSalirNuevoPais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalirNuevoPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirNuevoPais.Location = new System.Drawing.Point(215, 67);
            this.btnSalirNuevoPais.Name = "btnSalirNuevoPais";
            this.btnSalirNuevoPais.Size = new System.Drawing.Size(75, 23);
            this.btnSalirNuevoPais.TabIndex = 3;
            this.btnSalirNuevoPais.Text = "Salir";
            this.btnSalirNuevoPais.UseVisualStyleBackColor = true;
            this.btnSalirNuevoPais.Click += new System.EventHandler(this.btnSalirNuevoPais_Click);
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelBarra.Controls.Add(this.titulo);
            this.panelBarra.Controls.Add(this.btnSalirMenu);
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(300, 20);
            this.panelBarra.TabIndex = 7;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(14, 4);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(79, 13);
            this.titulo.TabIndex = 5;
            this.titulo.Text = "Agregar Pais";
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalirMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalirMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalirMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalirMenu.Location = new System.Drawing.Point(280, 0);
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(20, 20);
            this.btnSalirMenu.TabIndex = 4;
            this.btnSalirMenu.Text = "X";
            this.btnSalirMenu.UseVisualStyleBackColor = false;
            this.btnSalirMenu.Click += new System.EventHandler(this.btnSalirMenu_Click);
            // 
            // NuevoPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(300, 101);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.btnSalirNuevoPais);
            this.Controls.Add(this.btnAceptarNuevoPais);
            this.Controls.Add(this.txtNuevoPais);
            this.Controls.Add(this.lblNuevoPais);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoPais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo País";
            this.Load += new System.EventHandler(this.NuevoPais_Load);
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoPais;
        private System.Windows.Forms.TextBox txtNuevoPais;
        private System.Windows.Forms.Button btnAceptarNuevoPais;
        private System.Windows.Forms.Button btnSalirNuevoPais;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button btnSalirMenu;
    }
}