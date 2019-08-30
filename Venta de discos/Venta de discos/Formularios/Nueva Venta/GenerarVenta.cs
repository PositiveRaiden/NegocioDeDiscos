using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Venta_de_discos
{
    public partial class GenerarVenta : Form
    {
        public GenerarVenta()
        {
            InitializeComponent();
        }

        private void VentaDeDiscos_Load(object sender, EventArgs e)
        {
            ArrayList tiposDocumentos = new ArrayList();
            tiposDocumentos.Add("DNI");
            tiposDocumentos.Add("Pasaporte");
            tiposDocumentos.Add("Libreta Cívica");
            tiposDocumentos.Add("Libreta de Enrolamiento");
            cmbTipoDocumento.DataSource = tiposDocumentos;
            lblFecha.Text = "Fecha Actual: " + DateTime.Now.ToString("G");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
