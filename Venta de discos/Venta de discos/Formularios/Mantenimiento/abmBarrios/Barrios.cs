using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_de_discos.Formularios.Mantenimiento
{
    public partial class Barrios : Form
    {
        public Barrios()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoBarrio frm = new NuevoBarrio();
            frm.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarBarrio frm = new ModificarBarrio();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
