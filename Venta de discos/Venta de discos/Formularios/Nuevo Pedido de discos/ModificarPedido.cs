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

namespace Venta_de_discos.Formularios.Nuevo_Pedido_de_discos
{
    public partial class ModificarPedido : Form
    {
        string idPedido;
        PedidosRepositorio pedidosRepositorio = new PedidosRepositorio();
        DiscosRepositorio discosRepositorio = new DiscosRepositorio();

        public ModificarPedido(string id)
        {
            InitializeComponent();
            idPedido = id;
            //var pedido = pedidosRepositorio.ObtenerPedido(idPedido);

        }

        private void ModificarPedido_Load(object sender, EventArgs e)
        {
            cargarDiscos();
            cargarDetallePedido();
        }

        private void cargarDiscos()
        {
            var discos = discosRepositorio.ObtenerDiscos();
            dataGridView1.DataSource = discos;
        }
        private void cargarDetallePedido()
        {
            var detallesPedidoSeleccionado = pedidosRepositorio.ObtenerDetallesPedidoParaModificar(idPedido);

            foreach (DataRow row in detallesPedidoSeleccionado.Rows)
            {
                dataGridView2.Rows.Add(DetalleATabla(row));
            }
        }
        private string[] DetalleATabla(DataRow Row)
        {
            var row = new string[] {
                    Row["id"].ToString(),
                    Row["id_Disco"].ToString(),
                    Row["Nombre album"].ToString(),
                    Row["Cantidad Pedida"].ToString()
                };
            return row;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var discosAgregados = dataGridView2.Rows;
            var seleccionadas = dataGridView1.SelectedRows;
            bool existe = false;
            foreach (DataGridViewRow seleccionada in seleccionadas)
            {
                var codigo = seleccionada.Cells["Id"].Value?.ToString();
                foreach (DataGridViewRow agregada in discosAgregados)
                {
                    if (agregada.Cells["id_Disco"].Value?.ToString() == codigo)
                    {
                        MessageBox.Show("Disco ya agregado");
                        existe = true;
                        break;
                    }

                }

                if (existe == false)
                {
                    var random = new Random();
                    var value = random.Next(100, 1000);
                    var fila = new string[] {
                    "value",
                    seleccionada.Cells["id"].Value?.ToString(),
                    seleccionada.Cells["Nombre Album"].Value?.ToString(),
                    "0"
                    };

                    dataGridView2.Rows.Add(fila);
                }

            };
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("No hay filas para eliminar.");
                return;
            }
            dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
        }
    }
}
