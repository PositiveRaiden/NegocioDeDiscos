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
    public partial class Paises : Form
    {
        PaisRepositorio paisRepositorio = new PaisRepositorio();
        public Paises()
        {
            InitializeComponent();
        }

        

        private void actualizarPaises()
        {

            var paises = paisRepositorio.ObtenerPais();
            dgvPais.DataSource = paises;
            this.dgvPais.Columns["id"].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoPais frm = new NuevoPais();
            frm.ShowDialog();
            actualizarPaises();
        }

        private void Paises_Load_1(object sender, EventArgs e)
        {
            actualizarPaises();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var seleccionados = dgvPais.SelectedRows;
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

                if (paisRepositorio.Eliminar(id.ToString()))
                {
                    MessageBox.Show($"Usted Elimino a {nombre}");
                    actualizarPaises();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var seleccionados = dgvPais.SelectedRows;
            if (seleccionados.Count == 0 || seleccionados.Count > 1)
            {
                MessageBox.Show("Deberia seleccionar una fila");
                return;

            }
            foreach (DataGridViewRow fila in seleccionados)
            {
                var id = fila.Cells[0].Value;

                var ventana = new ModificarPais(id.ToString());
                ventana.ShowDialog();
                actualizarPaises();
            }
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}