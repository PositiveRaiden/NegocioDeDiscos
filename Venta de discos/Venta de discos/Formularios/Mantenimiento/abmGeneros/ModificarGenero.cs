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

namespace Venta_de_discos.Formularios.Mantenimiento.abmGeneros
{
    public partial class ModificarGenero : Form
    {
        //IS NOT WORKING
        GenerosRepositorio generosRepositorio;
        Genero genero;
        string _id;

        public ModificarGenero(string generoId)
        {
            InitializeComponent();
            generosRepositorio = new GenerosRepositorio();
            genero = generosRepositorio.ObtenerGenero(generoId);
        }

        private void ModificarGenero_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var datosGenero = new Genero();
            datosGenero.Nombre = txtNombre.Text.Trim();
            datosGenero.Descripcion = txtDescripcion.Text.Trim();
            datosGenero.Id = _id;

            if (!genero.NombreValido())
            {
                MessageBox.Show("Nombre Inválido!");
                txtNombre.Text = "";
                txtNombre.Focus();
                return;
            }
            if (genero.NombreRepetido(genero.Nombre))
            {
                MessageBox.Show("Nombre ya existe!");
                txtNombre.Text = "";
                txtNombre.Focus();
                return;
            }
            if (!genero.DescripcionValida())
            {
                MessageBox.Show("Descripción Inválida!");
                txtDescripcion.Text = "";
                txtDescripcion.Focus();
                return;
            }


            if (generosRepositorio.Editar(datosGenero))
            {
                MessageBox.Show("La edicion ha finalizado correctamente.");
                this.Dispose();
            }
        }

        private void ModificarGenero_Load_1(object sender, EventArgs e)
        {
            txtNombre.Text = genero.Nombre;
            txtDescripcion.Text = genero.Descripcion;
            _id = genero.Id;
        }
    }
}
