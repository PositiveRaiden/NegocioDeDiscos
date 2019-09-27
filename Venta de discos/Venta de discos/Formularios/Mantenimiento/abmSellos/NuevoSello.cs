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

namespace Venta_de_discos.Formularios.Mantenimiento.abmSellos
{
    public partial class NuevoSello : Form
    {
        SelloRepositorio sellosRepositorios;
        public NuevoSello()
        {
            InitializeComponent();
            sellosRepositorios = new SelloRepositorio();

        }

        private void NuevoSello_Load(object sender, EventArgs e)
        {
            txtSello.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var sello = new SelloDiscografico();
            sello.Nombre = txtSello.Text.Trim();
            sello.Telefono = txtTelefono.Text.Trim();
            sello.Email = txtEmail.Text.Trim();

            if (!sello.NombreValido())
            {
                MessageBox.Show("Nombre Inválido!");
                txtSello.Text = "";
                txtSello.Focus();
                return;
            }
            if (sello.NombreRepetido(sello.Nombre))
            {
                MessageBox.Show("Nombre ya existe!");
                txtSello.Text = "";
                txtSello.Focus();
                return;
            }

            if (!sello.TelefonoValido(sello.Telefono))
            {
                MessageBox.Show("Telefono Inválido!");
                txtTelefono.Text = "";
                txtTelefono.Focus();
                return;
            }

            if (!sello.EmailValido(sello.Email))
            {
                MessageBox.Show("Email Inválido!");
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            }

            if (sellosRepositorios.Guardar(sello))
            {
                MessageBox.Show("Se agrego sello discografico con exito!");
                this.Dispose();
            }
        }
    }
}
