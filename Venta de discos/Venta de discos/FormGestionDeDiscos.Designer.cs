namespace Venta_de_discos
{
    partial class frmGestionDeDiscos
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
            this.btnCargarDisco = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalirGDD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarDisco
            // 
            this.btnCargarDisco.Location = new System.Drawing.Point(103, 59);
            this.btnCargarDisco.Name = "btnCargarDisco";
            this.btnCargarDisco.Size = new System.Drawing.Size(116, 23);
            this.btnCargarDisco.TabIndex = 3;
            this.btnCargarDisco.Text = "Cargar Disco";
            this.btnCargarDisco.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar Disco";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSalirGDD
            // 
            this.btnSalirGDD.Location = new System.Drawing.Point(256, 226);
            this.btnSalirGDD.Name = "btnSalirGDD";
            this.btnSalirGDD.Size = new System.Drawing.Size(75, 23);
            this.btnSalirGDD.TabIndex = 5;
            this.btnSalirGDD.Text = "Salir";
            this.btnSalirGDD.UseVisualStyleBackColor = true;
            // 
            // frmGestionDeDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 261);
            this.Controls.Add(this.btnSalirGDD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCargarDisco);
            this.Name = "frmGestionDeDiscos";
            this.Text = "Gestion De Discos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarDisco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalirGDD;
    }
}