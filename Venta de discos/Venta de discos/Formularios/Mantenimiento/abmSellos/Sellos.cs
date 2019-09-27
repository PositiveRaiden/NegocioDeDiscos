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

namespace Venta_de_discos.Formularios.Mantenimiento.abmSellos
{
    public partial class Sellos : Form
    {
        SelloRepositorio sellosRepositorio = new SelloRepositorio();

        public Sellos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void actualizarSellos()
        {
            var sellos = sellosRepositorio.ObtenerSello();
            dgvSellos.DataSource = sellos;
            this.dgvSellos.Columns["id"].Visible = false;
        }


        private void Sellos_Load(object sender, EventArgs e)
        {
            actualizarSellos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoSello frm = new NuevoSello();
            frm.ShowDialog();
            actualizarSellos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var seleccionados = dgvSellos.SelectedRows;
            if (seleccionados.Count == 0 || seleccionados.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila!");
                return;

            }
            foreach (DataGridViewRow fila in seleccionados)
            {
                var id = fila.Cells[0].Value;
                var ventana = new ModificarSello(id.ToString());
                ventana.ShowDialog();
                actualizarSellos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var seleccionados = dgvSellos.SelectedRows;
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

                if (sellosRepositorio.Eliminar(id.ToString()))
                {
                    MessageBox.Show($"Usted Elimino a {nombre}");
                    actualizarSellos();
                }

            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
