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
        string _id;

        public ModificarCliente(string clienteId)
        {
            InitializeComponent();
            clientesRepositorio = new ClientesRepositorio();
            cliente = clientesRepositorio.ObtenerCliente(clienteId);
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtCalle.Text = cliente.NumDoc;//leer comentario de abajo
            txtNumDoc.Text = cliente.Calle;//estos estan invertidos y no se por que pasa eso!!
            _id = cliente.Id;
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
