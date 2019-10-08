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

        public NuevoCliente()
        {
            InitializeComponent();
            clientesRepositorios = new ClientesRepositorio();
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
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

            if (clientesRepositorios.Guardar(cliente))
            {
                MessageBox.Show("Se agrego cliente con exito!");

                this.Dispose();
            }
        }
    }
}
