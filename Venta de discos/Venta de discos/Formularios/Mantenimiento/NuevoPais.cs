using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_de_discos.Clases;
using Venta_de_discos.Repositorios;

namespace Venta_de_discos.Formularios.Mantenimiento
{

    public partial class NuevoPais : Form
    {
        PaisRepositorio paisRepositorio;

        public NuevoPais()
        {
            InitializeComponent();
            paisRepositorio = new PaisRepositorio();
        }

        private void btnSalirNuevoPais_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarNuevoPais_Click(object sender, EventArgs e)
        {
            var pais = new Pais();
            pais.Nombre = txtNuevoPais.Text;

            if (paisRepositorio.Guardar(pais))
            {
                MessageBox.Show("Se agrego interprete con exito!");
                this.Dispose();
            }
        }
    }
}
