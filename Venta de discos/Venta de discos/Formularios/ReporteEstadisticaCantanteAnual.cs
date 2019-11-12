using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_de_discos.Formularios
{
    public partial class ReporteEstadisticaCantanteAnual : Form
    {
        public ReporteEstadisticaCantanteAnual()
        {
            InitializeComponent();
        }

        private void ReporteEstadisticaCantanteAnual_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            var adapter = new DataSetReporteEstadisticaCantanteAnualTableAdapters.InterpreteTableAdapter();
            var d = new DataSetReporteEstadisticaCantanteAnual.InterpreteDataTable();

            adapter.Fill(d);

            ////// creo el parametro CantBicisPorCategoriaDS con el calor datos;
            var ds = new ReportDataSource("DataSetReporteEstadisticasCantanteAnual", (DataTable)d);


            reportViewer1.LocalReport.DataSources.Clear();

            ////// envio este parametro al reporte
            reportViewer1.LocalReport.DataSources.Add(ds);

            this.reportViewer1.RefreshReport();
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
