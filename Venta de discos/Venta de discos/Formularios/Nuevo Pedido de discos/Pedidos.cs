using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            txtFecha.Tag = "aaaa-mm-dd";
            //Ponemos el texto por defecto
            txtFecha.Text = txtFecha.Tag.ToString();
            //Ponemos el froecolor en gris
            txtFecha.ForeColor = Color.Gray;

            //lo de abajo va aen el designer
            //txtFecha.GotFocus += new EventHandler(OnGetFocus);
            //txtFecha.LostFocus += new EventHandler(OnLostFocus);

        }

        public void cargarPedidos()
        {
            var pedidos = pedidosRepositorio.ObtenerPedidos();
            dataGridView1.DataSource = pedidos;
            dataGridView1.Columns["fechaPedido"].DefaultCellStyle.Format = "yyyy-MM-dd";
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


        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            filtrarVenta();
            if (dataGridView1.RowCount == 0)
            {
                dataGridView2.DataSource = null;
            }
        }

        private void filtrarVenta()
        {
            using (SqlConnection cnx = new SqlConnection("workstation id = GerardoDB.mssql.somee.com; packet size = 4096; user id = geraCrossfit_SQLLogin_1; pwd=otyvkmvxvm;data source = GerardoDB.mssql.somee.com; persist security info=False;initial catalog = GerardoDB"))
            {
                string sqltxt = "SELECT id as 'Numero de pedido', fechaPedido FROM Pedido WHERE fechapedido LIKE @param + '%' ";

                SqlCommand cmd = new SqlCommand(sqltxt, cnx);
                cmd.Parameters.AddWithValue("@param", txtFecha.Text.Trim());


                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dataGridView1.DataSource = dt;

            }
        }

        public void OnGetFocus(object sender, EventArgs e)
        {
            //Comprobamos si el texto es el default, y si lo es lo borramos
            if (txtFecha.Text.Contains(txtFecha.Tag.ToString()))
                txtFecha.Text = "";
            //Ponemos el color en negro
            txtFecha.ForeColor = Color.Black;

        }

        public void OnLostFocus(object sender, EventArgs e)
        {
            //En caso de que no haya texto, añadimos el texto por defecto y ponemos el color en gris
            if (String.IsNullOrWhiteSpace(txtFecha.Text))
            {
                txtFecha.Text = txtFecha.Tag.ToString();
                txtFecha.ForeColor = Color.Gray;

            }
        }
    }
}
