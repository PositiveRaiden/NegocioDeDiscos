using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_de_discos.Repositorios;

namespace Venta_de_discos.Formularios.Nuevo_Pedido_de_discos
{
    public partial class Pedidos : Form
    {
        PedidosRepositorio pedidosRepositorio = new PedidosRepositorio();
        public Pedidos()
        {
            InitializeComponent();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            cargarPedidos();
        }
        public void cargarPedidos()
        {
            var pedidos = pedidosRepositorio.ObtenerPedidos();
            dataGridView1.DataSource = pedidos;
        }

        private void btnAñadirDisco_Click(object sender, EventArgs e)
        {
            NuevoPedido frm = new NuevoPedido();
            frm.ShowDialog();
            cargarPedidos();
        }
    }
}
