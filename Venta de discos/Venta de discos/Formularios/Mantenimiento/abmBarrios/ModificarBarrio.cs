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

namespace Venta_de_discos.Formularios.Mantenimiento.abmBarrios
{
    public partial class ModificarBarrio : Form
    {
        BarriosRepositorio barriosRepositorio;
        Barrio barrio;
        string _id;

        public ModificarBarrio(string barrioId)
        {
            InitializeComponent();
            barriosRepositorio = new BarriosRepositorio();
            barrio = barriosRepositorio.ObtenerBarrio(barrioId);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            var datosBarrio = new Barrio();
            datosBarrio.Nombre = txtBarrio.Text.Trim();
            datosBarrio.Localidad = txtLocalidad.Text.Trim();
            datosBarrio.Id = _id;

            if (!datosBarrio.NombreValido())
            {
                MessageBox.Show("Nombre inválido!");
                txtBarrio.Text = "";
                txtBarrio.Focus();
                return;
            }
            if (datosBarrio.Nombre != barrio.Nombre)
            {
                if (datosBarrio.NombreRepetido(datosBarrio.Nombre))
                {
                    MessageBox.Show("Nombre ya existente!");
                    txtBarrio.Text = "";
                    txtBarrio.Focus();
                    return;
                }
            }

            if (!datosBarrio.LocalidadValida())
            {
                MessageBox.Show("Localidad inválida!");
                txtLocalidad.Text = "";
                txtLocalidad.Focus();
                return;
            }
            if (barriosRepositorio.Editar(datosBarrio))
            {
                MessageBox.Show("La edición ha finalizado correctamente.");
                this.Dispose();
            }

        }

        private void ModificarBarrio_Load(object sender, EventArgs e)
        {
            txtBarrio.Text = barrio.Nombre;
            txtLocalidad.Text = barrio.Localidad;
            _id = barrio.Id;
        }
    }
}
