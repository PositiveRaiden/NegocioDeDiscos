using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_de_discos.Formularios.Mantenimiento.ajusteDiscos
{
    public partial class AjustesDiscos : Form
    {
        DiscosRepositorio disc;
        public AjustesDiscos()
        {
            InitializeComponent();
            disc = new DiscosRepositorio();
        }

        private void AjustesDiscos_Load(object sender, EventArgs e)
        {
            CargarDiscos();
        }

        private void CargarDiscos()
        {
            //dataGridView1.Rows.Clear();
            var discos = disc.ObtenerDiscos();
            dataGridView1.DataSource = discos;
            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["Precio"].Visible = false;
            this.dataGridView1.Columns["Año edicion"].Visible = false;
            this.dataGridView1.Columns["Genero"].Visible = false;
            this.dataGridView1.Columns["Sello Discografico"].Visible = false;
            this.dataGridView1.Columns["Interprete"].Visible = false;



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var seleccionados = dataGridView1.SelectedRows;
            if (seleccionados.Count == 0 || seleccionados.Count > 1)
            {
                MessageBox.Show("Deberia seleccionar una fila.");
                return;
            }
            foreach (DataGridViewRow fila in seleccionados)
            {
                var id = fila.Cells[0].Value;

                var ventana = new ModificarStock(id.ToString());
                ventana.ShowDialog();
                CargarDiscos();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
