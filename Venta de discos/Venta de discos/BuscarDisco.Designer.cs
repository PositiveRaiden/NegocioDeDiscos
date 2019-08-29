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
            this.lblIntrprete = new System.Windows.Forms.Label();
            this.btnBuscarDisco = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbInterprete = new System.Windows.Forms.ComboBox();
            this.btnAñadirDisco = new System.Windows.Forms.Button();
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
            // lblIntrprete
            // 
            this.lblIntrprete.AutoSize = true;
            this.lblIntrprete.Location = new System.Drawing.Point(72, 27);
            this.lblIntrprete.Name = "lblIntrprete";
            this.lblIntrprete.Size = new System.Drawing.Size(52, 13);
            this.lblIntrprete.TabIndex = 1;
            this.lblIntrprete.Text = "Intérprete";
            this.lblIntrprete.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuscarDisco
            // 
            this.btnBuscarDisco.Location = new System.Drawing.Point(236, 22);
            this.btnBuscarDisco.Name = "btnBuscarDisco";
            this.btnBuscarDisco.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDisco.TabIndex = 3;
            this.btnBuscarDisco.Text = "Buscar";
            this.btnBuscarDisco.UseVisualStyleBackColor = true;
            this.btnBuscarDisco.Click += new System.EventHandler(this.btnBuscarDisco_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(677, 328);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbInterprete
            // 
            this.cmbInterprete.FormattingEnabled = true;
            this.cmbInterprete.Location = new System.Drawing.Point(127, 22);
            this.cmbInterprete.Name = "cmbInterprete";
            this.cmbInterprete.Size = new System.Drawing.Size(103, 21);
            this.cmbInterprete.TabIndex = 17;
            // 
            // btnAñadirDisco
            // 
            this.btnAñadirDisco.Location = new System.Drawing.Point(596, 328);
            this.btnAñadirDisco.Name = "btnAñadirDisco";
            this.btnAñadirDisco.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirDisco.TabIndex = 5;
            this.btnAñadirDisco.Text = "Añadir Disco";
            this.btnAñadirDisco.UseVisualStyleBackColor = true;
            this.btnAñadirDisco.Click += new System.EventHandler(this.btnAñadirDisco_Click);
            // 
            // BuscarDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.cmbInterprete);
            this.Controls.Add(this.btnAñadirDisco);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarDisco);
            this.Controls.Add(this.lblIntrprete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BuscarDisco";
            this.Text = "Buscar Discos ";
            this.Load += new System.EventHandler(this.BuscarDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblIntrprete;
        private System.Windows.Forms.Button btnBuscarDisco;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbInterprete;
        private System.Windows.Forms.Button btnAñadirDisco;
    }
}