using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_de_discos.Formularios.Mantenimiento.abmBarrios;
using Venta_de_discos.Repositorios;

namespace Venta_de_discos.Formularios.Mantenimiento.Barrios
{
    public partial class Barrios : Form
    {
        BarriosRepositorio barriosRepositorio = new BarriosRepositorio();

        public Barrios()
        {
            InitializeComponent();
        }

        private void actualizarBarrios()
        {
            var barrios = barriosRepositorio.ObtenerBarrio();
            dgvBarrios.DataSource = barrios;
            this.dgvBarrios.Columns["id"].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoBarrio frm = new NuevoBarrio();
            frm.ShowDialog();
            actualizarBarrios();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var seleccionados = dgvBarrios.SelectedRows;
            if (seleccionados.Count == 0 || seleccionados.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila!");
                return;

            }
            foreach (DataGridViewRow fila in seleccionados)
            {
                var id = fila.Cells[0].Value;
                var ventana = new ModificarBarrio(id.ToString());
                ventana.ShowDialog();
                actualizarBarrios();
            }
        }

        private void Barrios_Load(object sender, EventArgs e)
        {
            actualizarBarrios();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            var seleccionados = dgvBarrios.SelectedRows;
            if (seleccionados.Count == 0 || seleccionados.Count > 1)
            {
                MessageBox.Show("Primero seleccione una fila!");
                return;
            }
            foreach (DataGridViewRow fila in seleccionados)
            {
                var nombre = fila.Cells[1].Value;
                var id = fila.Cells[0].Value;

                var confirmacion = MessageBox.Show($"¿Está seguro/a de eliminar a {nombre}?",
                    "Confirmar operación",
                    MessageBoxButtons.YesNo);

                if (confirmacion.Equals(DialogResult.No))
                    return;

                if (barriosRepositorio.Eliminar(id.ToString()))
                {
                    MessageBox.Show($"Usted eliminó a {nombre}.");
                    actualizarBarrios();
                }

            }

        }
    }
}
