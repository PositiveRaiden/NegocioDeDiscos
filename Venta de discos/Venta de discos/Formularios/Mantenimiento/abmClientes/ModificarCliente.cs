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

namespace Venta_de_discos.Formularios.Mantenimiento.abmCliente
{
    public partial class ModificarCliente : Form
    {
        ClientesRepositorio clientesRepositorio;
        Cliente cliente;
        BarriosRepositorio barrioRepositorio;
        TipoDocRepositorio tipoDocRepositorio;
        string _id;

        public ModificarCliente(string clienteId)
        {
            InitializeComponent();
            clientesRepositorio = new ClientesRepositorio();
            barrioRepositorio = new BarriosRepositorio();
            tipoDocRepositorio = new TipoDocRepositorio();
            cliente = clientesRepositorio.ObtenerCliente(clienteId);
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtCalle.Text = cliente.NumDoc;//leer comentario de abajo
            txtNumDoc.Text = cliente.Calle;//estos estan invertidos y no se por que pasa eso!!
            cmbBarrio.SelectedValue = cliente.Id_Barrio;
            ActualizarComboBarrio();
            cmbTipoDoc.SelectedValue = cliente.Id_TipoDoc;
            ActualizarComboTipoDoc();
            _id = cliente.Id;
        }

        private void ActualizarComboBarrio()
        {
            var barrios = barrioRepositorio.ObtenerBarrio();
            cmbBarrio.ValueMember = "Id";
            cmbBarrio.DisplayMember = "nombre";
            cmbBarrio.DataSource = barrios;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (DataRow row in barrios.Rows)
            {
                collection.Add(Convert.ToString(row["nombre"]));
            }

            cmbBarrio.AutoCompleteCustomSource = collection;
            cmbBarrio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBarrio.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void ActualizarComboTipoDoc()
        {
            var tipoDoc = tipoDocRepositorio.ObtenerTipoDoc();
            cmbTipoDoc.ValueMember = "Id";
            cmbTipoDoc.DisplayMember = "nombre";
            cmbTipoDoc.DataSource = tipoDoc;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (DataRow row in tipoDoc.Rows)
            {
                collection.Add(Convert.ToString(row["nombre"]));
            }

            cmbTipoDoc.AutoCompleteCustomSource = collection;
            cmbTipoDoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTipoDoc.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var datosCliente = new Cliente();
            datosCliente.Nombre = txtNombre.Text.Trim();
            datosCliente.Apellido = txtApellido.Text.Trim();
            datosCliente.Calle = txtCalle.Text.Trim();
            datosCliente.NumDoc = txtNumDoc.Text.Trim();
            datosCliente.Id = _id;

            if (clientesRepositorio.Editar(datosCliente))
            {
                MessageBox.Show("La edicion ha finalizado correctamente.");
                this.Dispose();
            }
        }
    }
}
