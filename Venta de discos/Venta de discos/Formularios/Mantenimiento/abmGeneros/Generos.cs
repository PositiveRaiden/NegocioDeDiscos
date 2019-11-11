using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_de_discos.Formularios.Mantenimiento.abmGeneros;
using Venta_de_discos.Repositorios;

namespace Venta_de_discos.Formularios.Mantenimiento.Generos
{
    public partial class Generos : Form
    {

        GenerosRepositorio generosRepositorio = new GenerosRepositorio();

        public Generos()
        {
            InitializeComponent();
        }

        private void actualizarGeneros()
        {
            var generos = generosRepositorio.ObtenerGenero();
            dgvGeneros.DataSource = generos;
            this.dgvGeneros.Columns["id"].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoGenero frm = new NuevoGenero();
            frm.ShowDialog();
            actualizarGeneros();

        }

        private void Genero_Load(object sender, EventArgs e)
        {
            actualizarGeneros();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var seleccionados = dgvGeneros.SelectedRows;
            if (seleccionados.Count == 0 || seleccionados.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila!");
                return;

            }
            foreach (DataGridViewRow fila in seleccionados)
            {
                var id = fila.Cells[0].Value;
                var ventana = new ModificarGenero(id.ToString());
                ventana.ShowDialog();
                actualizarGeneros();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var seleccionados = dgvGeneros.SelectedRows;
            if (seleccionados.Count == 0 || seleccionados.Count > 1)
            {
                MessageBox.Show("Deberia seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccionados)
            {
                var nombre = fila.Cells[1].Value;
                var id = fila.Cells[0].Value;

                var confirmacion = MessageBox.Show($"¿Esta seguro/a de eliminar a {nombre}?",
                    "Confirmar operacion",
                    MessageBoxButtons.YesNo);

                if (confirmacion.Equals(DialogResult.No))
                    return;

                if (generosRepositorio.Eliminar(id.ToString()))
                {
                    MessageBox.Show($"Usted Elimino a {nombre}");
                    actualizarGeneros();
                }

            }
        }

        private void dgvGeneros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
