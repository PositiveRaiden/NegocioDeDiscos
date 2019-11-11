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

namespace Venta_de_discos.Formularios.Mantenimiento.Barrios
{
    public partial class NuevoBarrio : Form
    {
        BarriosRepositorio barriosRepositorios;

        public NuevoBarrio()
        {
            InitializeComponent();
            barriosRepositorios = new BarriosRepositorio();
        }

        private void NuevoBarrio_Load(object sender, EventArgs e)
        {
            txtBarrio.Focus();
        }

        private void btnSalirNuevoPais_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {


        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            var barrio = new Barrio();
            barrio.Nombre = txtBarrio.Text.Trim();
            barrio.Localidad = txtLocalidad.Text.Trim();

            if (!barrio.NombreValido())
            {
                MessageBox.Show("Nombre inválido!");
                txtBarrio.Text = "";
                txtBarrio.Focus();
                return;
            }
            if (barrio.NombreRepetido(barrio.Nombre))
            {
                MessageBox.Show("Nombre ya existente!");
                txtBarrio.Text = "";
                txtBarrio.Focus();
                return;
            }

            if (!barrio.LocalidadValida())
            {
                MessageBox.Show("Localidad inválida!");
                txtLocalidad.Text = "";
                txtLocalidad.Focus();
                return;
            }

            if (barriosRepositorios.Guardar(barrio))
            {
                MessageBox.Show("Se agregó barrio con éxito!");

                this.Dispose();
            }
        }

        private void NuevoBarrio_Load_1(object sender, EventArgs e)
        {

        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
