namespace Venta_de_discos.Formularios
{
    partial class ReporteEstadisticasAlbum
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetDiscosMinimos = new Venta_de_discos.Formularios.DataSetDiscosMinimos();
            this.DataTable1TableAdapter = new Venta_de_discos.Formularios.DataSetDiscosMinimosTableAdapters.DataTable1TableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDiscosMinimos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSetDiscosMinimos;
            // 
            // DataSetDiscosMinimos
            // 
            this.DataSetDiscosMinimos.DataSetName = "DataSetDiscosMinimos";
            this.DataSetDiscosMinimos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetEstadisticasVentasAlbum";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Venta_de_discos.Formularios.ReporteEstadisticasVentasAlbum.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteEstadisticasAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 413);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteEstadisticasAlbum";
            this.Text = "ReporteEstadisticasAlbum";
            this.Load += new System.EventHandler(this.ReporteEstadisticasAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDiscosMinimos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSetDiscosMinimos DataSetDiscosMinimos;
        private DataSetDiscosMinimosTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}