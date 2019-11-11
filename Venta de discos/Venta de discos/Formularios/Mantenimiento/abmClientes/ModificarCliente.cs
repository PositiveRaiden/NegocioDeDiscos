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
using Venta_de_discos.Formularios.Mantenimiento.Barrios;
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
            txtCalle.Text = cliente.Calle;//leer comentario de abajo
            txtNumDoc.Text = cliente.NumDoc;//estos estan invertidos y no se por que pasa eso!!
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
            if (cmbTipoDoc.SelectedValue is null)
            {
                MessageBox.Show("Tipo Documento no existe!");
                cmbTipoDoc.Focus();
                return;
            }
            else
            {
                datosCliente.Id_TipoDoc = cmbTipoDoc.SelectedValue.ToString();
            }
            if (cmbBarrio.SelectedValue is null)
            {
                MessageBox.Show("Barrio no existe!");
                cmbBarrio.Focus();
                return;
            }
            else
            {
                datosCliente.Id_Barrio = cmbBarrio.SelectedValue.ToString();
            }
            datosCliente.Id = _id;

            if (!datosCliente.NombreValido())
            {
                MessageBox.Show("Nombre Invalido!");
                txtNombre.Text = "";
                txtNombre.Focus();
                return;
            }
            if (!datosCliente.ApellidoValido())
            {
                MessageBox.Show("Apellido Invalido!");
                txtApellido.Text = "";
                txtApellido.Focus();
                return;
            }



            if (cmbTipoDoc.SelectedValue.ToString() == "1")
            {
                if (!datosCliente.DNIValido())
                {
                    MessageBox.Show("DNI Invalido!");
                    txtNumDoc.Text = "";
                    txtNumDoc.Focus();
                    return;
                }
            }
            if (cmbTipoDoc.SelectedValue.ToString() == "2")
            {
                if (!datosCliente.LCValido())
                {
                    MessageBox.Show("LC Invalido!");
                    txtNumDoc.Text = "";
                    txtNumDoc.Focus();
                    return;
                }
            }
            if (cmbTipoDoc.SelectedValue.ToString() == "3")
            {
                if (!datosCliente.PasaporteValido())
                {
                    MessageBox.Show("Pasaporte Invalido!");
                    txtNumDoc.Text = "";
                    txtNumDoc.Focus();
                    return;
                }
            }

            if (datosCliente.NumDoc != cliente.NumDoc)
            {

                if (datosCliente.numDocRepetido(cliente.NumDoc))
                {
                    MessageBox.Show("Numero de documento ya existe!");
                    txtNumDoc.Text = "";
                    txtNumDoc.Focus();
                    return;
                }
            }

            if (!datosCliente.CalleValida())
            {
                MessageBox.Show("Calle Invalida!");
                txtCalle.Text = "";
                txtCalle.Focus();
                return;
            }

            if (clientesRepositorio.Editar(datosCliente))
            {
                MessageBox.Show("La edicion ha finalizado correctamente.");
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoBarrio frm = new NuevoBarrio();
            frm.ShowDialog();
            ActualizarComboBarrio();
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
