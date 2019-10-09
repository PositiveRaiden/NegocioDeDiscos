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
using Venta_de_discos.Formularios.Nueva_Venta;
using Venta_de_discos.Repositorios;

namespace Venta_de_discos
{
    public partial class GenerarVenta : Form
    {
        VentasRepositorio VentasRepositorio = new VentasRepositorio();
        public GenerarVenta()
        {
            InitializeComponent();
        }

        private void VentaDeDiscos_Load(object sender, EventArgs e)
        {            
            cargarVentas();
        }

        public void cargarVentas()
        {
            var ventas = VentasRepositorio.ObtenerVentas();
            dgvVentas.DataSource = ventas;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaVenta frm = new NuevaVenta();
            frm.ShowDialog();
        }
    }
}
