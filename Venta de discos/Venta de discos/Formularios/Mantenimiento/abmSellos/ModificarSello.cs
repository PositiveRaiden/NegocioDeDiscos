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
    public partial class ModificarSello : Form
    {
        SelloRepositorio sellosRepositorio;
        SelloDiscografico sello;
        string _id;

        public ModificarSello(string selloId)
        {
            InitializeComponent();
            sellosRepositorio = new SelloRepositorio();
            sello = sellosRepositorio.ObtenerSello(selloId);
        }

        private void ModificarSello_Load(object sender, EventArgs e)
        {
            txtSello.Text = sello.Nombre;
            txtTelefono.Text = sello.Telefono;
            txtEmail.Text = sello.Email;
            _id = sello.Id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var datosSello = new SelloDiscografico();
            datosSello.Nombre = txtSello.Text.Trim();
            datosSello.Telefono = txtTelefono.Text.Trim();
            datosSello.Email = txtEmail.Text.Trim();
            datosSello.Id = _id;

            if (!datosSello.NombreValido())
            {
                MessageBox.Show("Nombre Inválido!");
                txtSello.Text = "";
                txtSello.Focus();
                return;
            }
            if (datosSello.NombreRepetido(datosSello.Nombre))
            {
                MessageBox.Show("Nombre ya existente!");
                txtSello.Text = "";
                txtSello.Focus();
                return;
            }
            if (!datosSello.TelefonoValido())
            {
                MessageBox.Show("Telefono Inválido!");
                txtTelefono.Text = "";
                txtTelefono.Focus();
                return;
            }
            if (!datosSello.EmailValido())
            {
                MessageBox.Show("Email Inválido!");
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            }

            if (sellosRepositorio.Editar(datosSello))
            {
                MessageBox.Show("La edicion ha finalizado correctamente.");
                this.Dispose();
            }
        }
    }
}
