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
    public partial class ReporteEstadisticasAlbum : Form
    {
        public ReporteEstadisticasAlbum()
        {
            InitializeComponent();
        }

        private void ReporteEstadisticasAlbum_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetDiscosMinimos.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSetDiscosMinimos.DataTable1);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
