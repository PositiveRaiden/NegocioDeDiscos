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
namespace Venta_de_discos.Formularios.Mantenimiento.Generos
{
    public partial class NuevoGenero : Form
    {
        GenerosRepositorio generosRepositorios;

        public NuevoGenero()
        {
            InitializeComponent();
            generosRepositorios = new GenerosRepositorio();

        }

        private void NuevoGenero_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            var genero =  new Genero();
            genero.Nombre = txtNombre.Text.Trim();
            genero.Descripcion = txtDescripcion.Text.Trim();

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

            if (generosRepositorios.Guardar(genero))
            {
                MessageBox.Show("Se agrego género con exito!");

                this.Dispose();
            }
        }
    }
}
