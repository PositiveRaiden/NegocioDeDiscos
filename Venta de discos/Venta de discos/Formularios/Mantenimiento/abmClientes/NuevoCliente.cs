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
using Venta_de_discos.Clases;

namespace Venta_de_discos.Formularios.Mantenimiento.abmCliente
{
    public partial class NuevoCliente : Form
    {
        ClientesRepositorio clientesRepositorios;
        TipoDocRepositorio tipoDocRepositorio;
        BarriosRepositorio barriosRepositorio;

        public NuevoCliente()
        {
            InitializeComponent();
            tipoDocRepositorio = new TipoDocRepositorio();
            barriosRepositorio = new BarriosRepositorio();
            clientesRepositorios = new ClientesRepositorio();
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
            ActualizarComboTipoDoc();
            ActualizarComboBarrios();
        }

        private void ActualizarComboTipoDoc()
        {
            var tiposDoc = tipoDocRepositorio.ObtenerTipoDoc();
            cmbTipoDoc.ValueMember = "Id";
            cmbTipoDoc.DisplayMember = "nombre";
            cmbTipoDoc.DataSource = tiposDoc;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (DataRow row in tiposDoc.Rows)
            {
                collection.Add(Convert.ToString(row["nombre"]));
            }

            cmbTipoDoc.AutoCompleteCustomSource = collection;
            cmbTipoDoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTipoDoc.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void ActualizarComboBarrios()
        {
            var barrios = barriosRepositorio.ObtenerBarrio();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //aca
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Nombre = txtNombre.Text.Trim();
            cliente.Apellido = txtApellido.Text.Trim();
            cliente.Calle = txtCalle.Text.Trim();
            cliente.NumDoc = txtNumDoc.Text.Trim();
            if (cmbTipoDoc.SelectedValue is null)
            {
                MessageBox.Show("Tipo Documento no existe!");
                cmbTipoDoc.Focus();
                return;
            }
            else
            {
                cliente.Id_TipoDoc = cmbTipoDoc.SelectedValue.ToString();
            }
            if (cmbBarrio.SelectedValue is null)
            {
                MessageBox.Show("Barrio no existe!");
                cmbBarrio.Focus();
                return;
            }
            else
            {
                cliente.Id_Barrio = cmbBarrio.SelectedValue.ToString();
            }

            if (!cliente.NombreValido())
            {
                MessageBox.Show("Nombre Invalido!");
                txtNombre.Text = "";
                txtNombre.Focus();
                return;
            }
            if (!cliente.ApellidoValido())
            {
                MessageBox.Show("Apellido Invalido!");
                txtApellido.Text = "";
                txtApellido.Focus();
                return;
            }



            if (cmbTipoDoc.SelectedValue.ToString() == "1")
            {
                if (!cliente.DNIValido())
                {
                    MessageBox.Show("DNI Invalido!");
                    txtNumDoc.Text = "";
                    txtNumDoc.Focus();
                    return;
                }
            }
            if (cmbTipoDoc.SelectedValue.ToString() == "2")
            {
                if (!cliente.LCValido())
                {
                    MessageBox.Show("LC Invalido!");
                    txtNumDoc.Text = "";
                    txtNumDoc.Focus();
                    return;
                }
            }
            if (cmbTipoDoc.SelectedValue.ToString() == "3")
            {
                if (!cliente.PasaporteValido())
                {
                    MessageBox.Show("Pasaporte Invalido!");
                    txtNumDoc.Text = "";
                    txtNumDoc.Focus();
                    return;
                }
            }


            if (cliente.numDocRepetido(cliente.NumDoc))
            {
                MessageBox.Show("Numero de documento ya existe!");
                txtNumDoc.Text = "";
                txtNumDoc.Focus();
                return;
            }

            if (!cliente.CalleValida())
            {
                MessageBox.Show("Calle Invalida!");
                txtCalle.Text = "";
                txtCalle.Focus();
                return;
            }






            if (clientesRepositorios.Guardar(cliente))
            {
                MessageBox.Show("Se agrego cliente con exito!");

                this.Dispose();
            }
        }
    }
}
