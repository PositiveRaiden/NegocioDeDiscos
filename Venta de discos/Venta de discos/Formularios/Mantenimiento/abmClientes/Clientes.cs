using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_de_discos.Clases;
using Venta_de_discos.Formularios.Mantenimiento.abmCliente;
using Venta_de_discos.Repositorios;

namespace Venta_de_discos.Formularios.Mantenimiento.abmCliente
{
    public partial class Clientes : Form
    {

        ClientesRepositorio clientesRepositorio = new ClientesRepositorio();
        TipoDocRepositorio tipoDocRepositorio = new TipoDocRepositorio();
        public Clientes()
        {
            InitializeComponent();
        }

        private void actualizarClientes()
        {
            var clientes = clientesRepositorio.ObtenerCliente();
            dgvClientes.DataSource = clientes;
            this.dgvClientes.Columns["id"].Visible = false;
            //this.dgvClientes.Columns["id_TipoDocumento"].Visible = false;
            dgvClientes.Columns[4].HeaderText = "Numero de Documento"; //este anda bien pero queda mejor asi
            dgvClientes.Columns[5].HeaderText = "Tipo Documento"; // Mismo eror que el de abajo
            dgvClientes.Columns[6].HeaderText = "Barrio"; // SOLUCION TEMPORAL, VER DESPUES POR QUE SE PONE "NOMBRE1"
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            actualizarClientes();
            ActualizarComboTipoDoc();

        }
        private void ActualizarComboTipoDoc()
        {

            var tiposDoc = tipoDocRepositorio.ObtenerTipoDoc();

            DataRow row = tiposDoc.NewRow();
            row["nombre"] = "TODOS";
            row["Id"] = 0;
            tiposDoc.Rows.InsertAt(row, 0);


            cmbTipoDocumento.ValueMember = "Id";
            cmbTipoDocumento.DisplayMember = "nombre";
            cmbTipoDocumento.DataSource = tiposDoc;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoCliente frm = new NuevoCliente();
            frm.ShowDialog();
            actualizarClientes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var seleccionados = dgvClientes.SelectedRows;
            if (seleccionados.Count == 0 || seleccionados.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila!");
                return;

            }
            foreach (DataGridViewRow fila in seleccionados)
            {
                var id = fila.Cells[0].Value;
                var ventana = new ModificarCliente(id.ToString());
                ventana.ShowDialog();
                actualizarClientes();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var seleccionados = dgvClientes.SelectedRows;
            if (seleccionados.Count == 0 || seleccionados.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccionados)
            {
                var id = fila.Cells[0].Value;
                var nombre = fila.Cells[1].Value;
                var apellido = fila.Cells[2].Value;
                

                var confirmacion = MessageBox.Show($"¿Está seguro/a de eliminar a {nombre} {apellido}?",
                    "Confirmar operación",
                    MessageBoxButtons.YesNo);

                if (confirmacion.Equals(DialogResult.No))
                    return;

                if (clientesRepositorio.Eliminar(id.ToString()))
                {
                    MessageBox.Show($"{nombre} {apellido} ha sido eliminado!");
                    actualizarClientes();
                }

            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbTipoDocumento.SelectedValue.ToString() == "0")
            {
                actualizarClientes();
                return;
            }
            ActualizarClientesSegunFiltro();
        }
        private void ActualizarClientesSegunFiltro()
        {
            var valor = txtNumeroDocumento.Text.Trim();

            if (cmbTipoDocumento.SelectedValue.ToString() == "1")
            {
                int number;
                if (!string.IsNullOrEmpty(valor) && valor.Length == 8 && int.TryParse(valor, out number))
                {
                    //NADA
                }
                else
                {
                    MessageBox.Show("DNI Inválido!");
                    txtNumeroDocumento.Text = "";
                    txtNumeroDocumento.Focus();
                    return;
                }


            }
            if (cmbTipoDocumento.SelectedValue.ToString() == "2")
            {
                int number;
                if (!string.IsNullOrEmpty(valor) && valor.Length == 7 && int.TryParse(valor, out number))
                {
                    //NADA
                }
                else
                {
                    MessageBox.Show("LC Inválido!");
                    txtNumeroDocumento.Text = "";
                    txtNumeroDocumento.Focus();
                    return;
                }
            }
            if (cmbTipoDocumento.SelectedValue.ToString() == "3")
            {
                String expresion;
                expresion = "^[a-z]{3}[0-9]{6}[a-z]{1}$";
                if (Regex.IsMatch(valor, expresion))
                {
                    if (Regex.Replace(valor, expresion, String.Empty).Length == 0)
                    {
                        //NADA
                    }
                    else
                    {
                        MessageBox.Show("Pasaporte Inválido!");
                        txtNumeroDocumento.Text = "";
                        txtNumeroDocumento.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Pasaporte Inválido!");
                    txtNumeroDocumento.Text = "";
                    txtNumeroDocumento.Focus();
                    return;
                }
            }

            var clientes = clientesRepositorio.ObtenerClientePorDocumento(valor.ToString());
            dgvClientes.DataSource = clientes;
            this.dgvClientes.Columns["id"].Visible = false;
        }

    }
}
