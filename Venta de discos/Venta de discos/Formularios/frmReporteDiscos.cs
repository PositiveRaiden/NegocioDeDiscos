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
    public partial class frmReporteDiscos : Form
    {
        public frmReporteDiscos()
        {
            InitializeComponent();
        }

        private void frmReporteDiscos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetDiscos.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSetDiscos.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
