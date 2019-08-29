using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_de_discos
{
    public partial class BuscarDisco : Form
    {
        discoRepertorio disc; 

        public BuscarDisco()
        {
            InitializeComponent();
            disc = new discoRepertorio();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BuscarDisco_Load(object sender, EventArgs e)
        {
            CargarComboInterprete();

        }

        private void CargarComboInterprete()
        {
            var interpretes = disc.ObtenerInterprete();
            cmbInterprete.DataSource = interpretes;
            cmbInterprete.ValueMember = "id";
            cmbInterprete.DisplayMember = "nombre";
        }

        private void btnBuscarDisco_Click(object sender, EventArgs e)
        {

            //actualizarDiscos()
        }
    }
}
