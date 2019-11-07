using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_de_discos.Formularios;

namespace Venta_de_discos
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte1 frm = new Reporte1();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmReporteDiscos frm = new frmReporteDiscos();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReporteVentas frm = new ReporteVentas();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReporteStockMinimo frm = new ReporteStockMinimo();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportePedidos frm = new ReportePedidos();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReporteEstadisticasAlbum frm = new ReporteEstadisticasAlbum();
            frm.ShowDialog();
        }
    }
}
