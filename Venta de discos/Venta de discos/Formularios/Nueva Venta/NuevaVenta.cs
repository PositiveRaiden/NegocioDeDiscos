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

namespace Venta_de_discos.Formularios.Nueva_Venta
{
    public partial class NuevaVenta : Form
    {
        VentasRepositorio ventasRepositorio = new VentasRepositorio();
        DiscosRepositorio discosRepositorio = new DiscosRepositorio();
        ClientesRepositorio clientesRepositorio = new ClientesRepositorio();

        public NuevaVenta()
        {
            InitializeComponent();
             clientesRepositorio = new ClientesRepositorio();

        }


        private void NuevaVenta_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            LblFechaHoy.Text = DateTime.Today.ToString("dd/MM/yyyy");
            ActualizarComboCliente();
        }

        private void ActualizarComboCliente()
        {
            var clientes = clientesRepositorio.ObtenerCliente();
            cmbCliente.ValueMember = "Id";
            cmbCliente.DisplayMember = "numDoc";
            cmbCliente.DataSource = clientes;


            //AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            //foreach (DataRow row in clientes.Rows)
            //{
            //    collection.Add(Convert.ToString(row["numDoc"]));
            //}

            //cmbCliente.AutoCompleteCustomSource = collection;
            //cmbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cmbCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void ActualizarGrilla()
        {
            var discos = discosRepositorio.ObtenerDiscos();
            dgvDiscos.DataSource = discos;
            this.dgvDiscos.Columns["id"].Visible = false;
            this.dgvDiscos.Columns["cantidad"].Visible = false;
            this.dgvDiscos.Columns["precio"].Visible = false;
            this.dgvDiscos.Columns["genero"].Visible = false;
            this.dgvDiscos.Columns["año edicion"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var discosAgregados = dgvVentas.Rows;
            var seleccionadas = dgvDiscos.SelectedRows;
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

                    dgvVentas.Rows.Add(fila);
                }

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvVentas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var fila = dgvVentas.Rows[e.RowIndex];
            int cantidad = 0;
            if (!int.TryParse(fila.Cells["Cantidad"].Value?.ToString(), out cantidad))
            {
                fila.Cells["Cantidad"].Value = null;
                fila.Cells["subtotal"].Value = null;
                ActualizarTotal();
                return;
            }
            var precioUnitario = decimal.Parse(fila.Cells["Precio"].Value.ToString());
            var subtotal = cantidad * precioUnitario;
            fila.Cells["subtotal"].Value = subtotal;
            ActualizarTotal();
            return;
        }















        private void ActualizarTotal()
        {
            var filas = dgvVentas.Rows;

            decimal total = 0;
            foreach (DataGridViewRow fila in filas)
            {
                if (fila.Cells["subtotal"].Value == null)
                    continue;
                total += decimal.Parse(fila.Cells["subtotal"].Value.ToString());
            }
            if (total != 0)
                txtTotal.Text = total.ToString();
            else
                txtTotal.Text = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //if(MessageBox.Show("Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //    Dispose();
            if (MessageBox.Show("Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Dispose();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            var discosAgregados = dgvVentas.Rows;//ventas es el 2, discos 1
            var seleccionadas = dgvDiscos.SelectedRows;
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
                    seleccionada.Cells["Precio"].Value?.ToString(),
                    seleccionada.Cells["Año Edicion"].Value?.ToString(),
                    seleccionada.Cells["Genero"].Value?.ToString(),
                    seleccionada.Cells["Sello Discografico"].Value?.ToString(),
                    seleccionada.Cells["Interprete"].Value.ToString()
                    };

                    dgvVentas.Rows.Add(fila);
                }

            };
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvVentas.Rows.RemoveAt(dgvVentas.CurrentRow.Index);
        }

        private List<DetalleVenta> PreparaDetalles()
        {
            var detalles = new List<DetalleVenta>();

            var filas = dgvVentas.Rows;

            foreach (DataGridViewRow fila in filas)
            {
                var detalle = new DetalleVenta()
                {
                    id_disco = fila.Cells["id"].Value?.ToString(),
                    cantidad = fila.Cells["Cantidad"].Value?.ToString(),
                    precio = fila.Cells["costo"].Value?.ToString()
                };
                detalles.Add(detalle);
            }
            return detalles;
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cmbCliente.SelectedValue.ToString();
            Cliente cliente = clientesRepositorio.ObtenerCliente(index);
            textBox1.Text = cliente.Nombre.ToString();
            textBox2.Text = cliente.Apellido.ToString();


        }
    }
    }

