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

namespace Venta_de_discos.Formularios.Mantenimiento
{
    public partial class Interpretes : Form
    {
        InterpretesRepositorio interpretesRepositorio = new InterpretesRepositorio();
        public Interpretes()
        {
            InitializeComponent();
        }

        private void Interpretes_Load(object sender, EventArgs e)
        {
            actualizarInterpretes();
        }
        private void actualizarInterpretes()
        {

            var interpretes = interpretesRepositorio.ObtenerInterpretes();
            dataGridView1.DataSource = interpretes;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoInterprete frm = new NuevoInterprete();
            frm.ShowDialog();
            actualizarInterpretes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var seleccionados = dataGridView1.SelectedRows;
            if (seleccionados.Count == 0 || seleccionados.Count > 1)
            {
                MessageBox.Show("Deberia seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccionados)
            {
                var nombre = fila.Cells[1].Value;
                var pais = fila.Cells[2].Value;
                var id = fila.Cells[0].Value;

                var confirmacion = MessageBox.Show($"¿Esta seguro/a de eliminar a {nombre}?",
                    "Confirmar operacio",
                    MessageBoxButtons.YesNo);

                if (confirmacion.Equals(DialogResult.No))
                    return;

                if (interpretesRepositorio.Eliminar(id.ToString()))
                {
                    MessageBox.Show($"Usted Elimino a {nombre}");
                    actualizarInterpretes();
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var seleccionados = dataGridView1.SelectedRows;
            if (seleccionados.Count == 0 || seleccionados.Count > 1)
            {
                MessageBox.Show("Deberia seleccionar una fila");
                return;

            }
            foreach (DataGridViewRow fila in seleccionados)
            {
                var id = fila.Cells[0].Value;

                var ventana = new ModificarInterprete(id.ToString());
                ventana.ShowDialog();
                actualizarInterpretes();
            }
        }
    }
}
