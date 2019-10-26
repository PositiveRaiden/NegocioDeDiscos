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
using System.Data.SqlClient;

namespace Venta_de_discos
{
    public partial class GenerarVenta : Form
    {
        VentasRepositorio ventasRepositorio = new VentasRepositorio();

        public GenerarVenta()
        {
            InitializeComponent();
            
        }

        private void VentaDeDiscos_Load(object sender, EventArgs e)
        {
            txtFecha.GotFocus += new EventHandler(this.TextGotFocus);
            txtFecha.LostFocus += new EventHandler(this.TextLostFocus);
            cargarVentas();
        }

        public void TextGotFocus(object sender, EventArgs e)
        {
            if (txtFecha.Text == "aaaa-mm-dd")
            {
                txtFecha.Text = "";
                txtFecha.ForeColor = Color.Black;
            }
            cargarVentas();
        }

        public void TextLostFocus(object sender, EventArgs e)
        {
            
            if (txtFecha.Text == "")
            {
                txtFecha.Text = "aaaa-mm-dd";
                txtFecha.ForeColor = Color.LightGray;
            }
            cargarVentas();
        }


        public void cargarVentas()
        {
            var ventas = ventasRepositorio.ObtenerVentas();

            dgvVentas.DataSource = ventas;
            dgvVentas.Columns["Fecha"].DefaultCellStyle.Format = "yyyy-MM-dd";
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
            cargarVentas();
        }

        public void cargarDetallesVenta(string idVenta)
        {
            var detalleVentas = ventasRepositorio.ObtenerDetallesVenta(idVenta);
            dgvDetalles.DataSource = detalleVentas;
        }

        private void dgvVentas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string idVenta = dgvVentas.SelectedCells[0].Value.ToString();
                cargarDetallesVenta(idVenta);
            }
            catch
            {
                //Sin esto no anda nose porque. index null no controlada
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var seleccionados = dgvVentas.SelectedRows;
            if (seleccionados.Count == 0 || seleccionados.Count > 1)
            {
                MessageBox.Show("Deberia seleccionar solo una fila");
                return;
            }

            //NO MODIFICO EL STOCK

            foreach (DataGridViewRow fila in seleccionados)
            {

                var id = fila.Cells[0].Value;

                var confirmacion = MessageBox.Show($"¿Esta seguro/a de eliminar la venta cuyo id es {id}?",
                    "Confirmar operacion",
                    MessageBoxButtons.YesNo);

                if (confirmacion.Equals(DialogResult.No))
                    return;

                if (ventasRepositorio.Eliminar(id.ToString()))
                {
                    MessageBox.Show($"Usted Elimino la venta con id:{id}");
                    cargarVentas();
                }


            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //MODIFICO STOCK
            var seleccionados = dgvVentas.SelectedRows;
            if (seleccionados.Count == 0 || seleccionados.Count > 1)
            {
                MessageBox.Show("Deberia seleccionar una fila");
                return;

            }
            foreach (DataGridViewRow fila in seleccionados)
            {
                var id = fila.Cells[0].Value;
                var idCli = fila.Cells[2].Value;
                var ventana = new ModificarVenta(id.ToString(), idCli.ToString());
                ventana.ShowDialog();
                cargarVentas();
            }
        }

        private void ActualizarVentasSegunFecha()
        {
     
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filtrarVenta();
            if (dgvVentas.RowCount == 0)
            {
                dgvDetalles.DataSource = null;
            }
        }

        private void filtrarVenta()
        {
            using (SqlConnection cnx = new SqlConnection("workstation id = GerardoDB.mssql.somee.com; packet size = 4096; user id = geraCrossfit_SQLLogin_1; pwd=otyvkmvxvm;data source = GerardoDB.mssql.somee.com; persist security info=False;initial catalog = GerardoDB"))
            {

                string query = "SELECT v.id as 'Numero de Venta', v.fecha as 'Fecha', " +
                      "v.id_Cliente as 'Número de Cliente', c.Nombre, v.importe_Total as 'Importe Total' FROM Venta v, " +
                       $"Cliente c WHERE v.id_Cliente = c.id AND v.fecha LIKE @param + '%'";

                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@param", txtFecha.Text.Trim());


                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dgvVentas.DataSource = dt;

            }
        }

        private void txtFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
