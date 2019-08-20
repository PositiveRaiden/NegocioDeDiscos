namespace Venta_de_discos
{
    partial class BuscarDisco
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarDisco = new System.Windows.Forms.TextBox();
            this.btnBuscarDisco = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAñadirDisco = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // txtBuscarDisco
            // 
            this.txtBuscarDisco.Location = new System.Drawing.Point(134, 25);
            this.txtBuscarDisco.Name = "txtBuscarDisco";
            this.txtBuscarDisco.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarDisco.TabIndex = 2;
            // 
            // btnBuscarDisco
            // 
            this.btnBuscarDisco.Location = new System.Drawing.Point(252, 23);
            this.btnBuscarDisco.Name = "btnBuscarDisco";
            this.btnBuscarDisco.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDisco.TabIndex = 3;
            this.btnBuscarDisco.Text = "Buscar";
            this.btnBuscarDisco.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(677, 331);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAñadirDisco
            // 
            this.btnAñadirDisco.Location = new System.Drawing.Point(584, 331);
            this.btnAñadirDisco.Name = "btnAñadirDisco";
            this.btnAñadirDisco.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirDisco.TabIndex = 5;
            this.btnAñadirDisco.Text = "Añadir Disco";
            this.btnAñadirDisco.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(467, 334);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cantidad";
            // 
            // BuscarDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAñadirDisco);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarDisco);
            this.Controls.Add(this.txtBuscarDisco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BuscarDisco";
            this.Text = "BuscarDisco";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarDisco;
        private System.Windows.Forms.Button btnBuscarDisco;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAñadirDisco;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
    }
}