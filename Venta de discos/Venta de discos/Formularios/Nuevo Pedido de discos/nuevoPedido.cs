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
using Venta_de_discos.Clases;
using Venta_de_discos.Repositorios;
using Venta_de_discos.Formularios.Discos;

namespace Venta_de_discos.Formularios.Nuevo_Pedido_de_discos
{
    public partial class NuevoPedido : Form
    {
        PedidosRepositorio pedidosRepositorio = new PedidosRepositorio();
        DiscosRepositorio discosRepositorio = new DiscosRepositorio();
        public NuevoPedido()
        {
            InitializeComponent();
        }

        private void NuevoPedido_Load(object sender, EventArgs e)
        {
            
            ActualizarGrilla();
            LblFechaHoy.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void ActualizarGrilla()
        {
            var discos = discosRepositorio.ObtenerDiscos();
            dataGridView1.DataSource = discos;
            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["cantidad"].Visible = false;
            this.dataGridView1.Columns["precio"].Visible = false;
            this.dataGridView1.Columns["genero"].Visible = false;
            this.dataGridView1.Columns["año edicion"].Visible = false;
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
                    if (agregada.Cells["id"].Value?.ToString() == codigo)
                    {
                        MessageBox.Show("Disco ya agregado");
                        existe = true;
                        break;
                    }

                }

                if (existe == false)
                {
                    var fila = new string[] {
                    seleccionada.Cells["id"].Value?.ToString(),
                    seleccionada.Cells["Nombre Album"].Value?.ToString() ,
                    "0",
                    seleccionada.Cells["Precio"].Value?.ToString(),
                    seleccionada.Cells["Año Edicion"].Value?.ToString(),
                    seleccionada.Cells["Genero"].Value?.ToString(),
                    seleccionada.Cells["Sello Discografico"].Value?.ToString(),
                    seleccionada.Cells["Interprete"].Value.ToString()
                    };

                    dataGridView2.Rows.Add(fila);
                }

            };

            }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Dispose();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var a = new Pedido()
                {

                    fechaPedido = DateTime.Today,
                    detallePedidos = PreparaDetalles()

                };
                pedidosRepositorio.Guardar(a); 
                MessageBox.Show("La operación se realizó con exito");
                this.Dispose();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error inesperado");
            }
        }

        private List<DetallePedido> PreparaDetalles()
        {
            var detalles = new List<DetallePedido>();

            var filas = dataGridView2.Rows;

            foreach (DataGridViewRow fila in filas)
            {
                var detalle = new DetallePedido()
                {
                    idDisco = fila.Cells["id"].Value?.ToString(),
                    cantidad = fila.Cells["Cantidad"].Value?.ToString()
                };
                detalles.Add(detalle);
            }
            return detalles;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filtroNombreAlbum_TextChanged(object sender, EventArgs e)
        {
            filtrarDisco();
        }

        private void filtroSello_TextChanged(object sender, EventArgs e)
        {
            filtrarDisco();
        }

        private void filtroInterprete_TextChanged(object sender, EventArgs e)
        {
            filtrarDisco();
        }
        private void filtrarDisco()
        {
            using (SqlConnection cnx = new SqlConnection("workstation id = GerardoDB.mssql.somee.com; packet size = 4096; user id = geraCrossfit_SQLLogin_1; pwd=otyvkmvxvm;data source = GerardoDB.mssql.somee.com; persist security info=False;initial catalog = GerardoDB"))
            {

                string query = "SELECT D.id,D.Nombre_Album as 'Nombre Album',D.Cantidad,D.Precio,D.Año_edicion as 'Año edicion',G.nombre as 'Genero',S.nombre as 'Sello Discografico',I.nombre as 'Interprete'  FROM Disco D, Genero G, Sello_Discografico S, Interprete I where D.id_genero = G.id AND D.id_selloDiscografico = S.id AND D.id_interprete = I.id AND I.nombre LIKE @paramI + '%' AND S.nombre LIKE @paramS + '%' AND D.Nombre_Album LIKE @paramN + '%' ";


                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@paramI", filtroInterprete.Text.Trim());
                cmd.Parameters.AddWithValue("@paramS", filtroSello.Text.Trim());
                cmd.Parameters.AddWithValue("@paramN", filtroNombreAlbum.Text.Trim());

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dataGridView1.DataSource = dt;

            }
        }

        private void btnNuevoDisco_Click(object sender, EventArgs e)
        {
            AgregarDisco frm = new AgregarDisco();
            frm.ShowDialog();
            ActualizarGrilla();
        }

        private void LblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
