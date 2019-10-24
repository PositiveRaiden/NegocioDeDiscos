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
            //if (dataGridView1.Rows.Count > 0)
            //{
            //    dataGridView1.Rows[1].Selected = true;
            //}

        }
        public void cargarDetallesPedido(string idPedido)
        {
            var detallesPedidos = pedidosRepositorio.ObtenerDetallesPedido(idPedido);
            dataGridView2.DataSource = detallesPedidos;
        }

        private void btnAñadirDisco_Click(object sender, EventArgs e)
        {
            NuevoPedido frm = new NuevoPedido();
            frm.ShowDialog();
            cargarPedidos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //MODIFICO STOCK
            var seleccionados = dataGridView1.SelectedRows;
            if (seleccionados.Count == 0 || seleccionados.Count > 1)
            {
                MessageBox.Show("Deberia seleccionar una fila");
                return;

            }
            foreach (DataGridViewRow fila in seleccionados)
            {
                var id = fila.Cells[0].Value;

                var ventana = new ModificarPedido(id.ToString());
                ventana.ShowDialog();
                cargarPedidos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //NO MODIFICO EL STOCK
            var seleccionados = dataGridView1.SelectedRows;
            if (seleccionados.Count == 0 || seleccionados.Count > 1)
            {
                MessageBox.Show("Deberia seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccionados)
            {

                var id = fila.Cells[0].Value;

                var confirmacion = MessageBox.Show($"¿Esta seguro/a de eliminar el pedido {id}?",
                    "Confirmar operacion",
                    MessageBoxButtons.YesNo);

                if (confirmacion.Equals(DialogResult.No))
                    return;

                if (pedidosRepositorio.Eliminar(id.ToString()))
                {
                    MessageBox.Show($"Usted Elimino a {id}");
                    cargarPedidos();
                }


            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string idPedido = dataGridView1.SelectedCells[0].Value.ToString();
                cargarDetallesPedido(idPedido);
            }
            catch
            {
                //Sin esto no anda nose porque. index null no controlada
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
