using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_de_discos.Formularios.Nuevo_Pedido_de_discos
{
    public partial class NuevoPedido : Form
    {
        DiscosRepositorio discosRepositorio = new DiscosRepositorio();
        public NuevoPedido()
        {
            InitializeComponent();
        }

        private void NuevoPedido_Load(object sender, EventArgs e)
        {
            
            ActualizarGrilla();
            LblFechaHoy.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }
        private void ActualizarGrilla()
        {
            var discos = discosRepositorio.ObtenerDiscos();
            dataGridView1.DataSource = discos;
            this.dataGridView1.Columns["id"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var discosAgregados = dataGridView2.Rows;
            var seleccionadas = dataGridView1.SelectedRows;
            bool existe = false;
            foreach (DataGridViewRow seleccionada in seleccionadas)
            {
                var codigo = seleccionada.Cells["Id"].Value?.ToString();
                foreach (DataGridViewRow agregada in discosAgregados)
                {
                    if (agregada.Cells["id"].Value?.ToString() == codigo)
                    {
                        MessageBox.Show("Disco ya agregado");
                        existe = true;
                        break;
                    }

                }

                if (existe == false)
                {
                    var fila = new string[] {
                    seleccionada.Cells["id"].Value?.ToString(),
                    seleccionada.Cells["Nombre Album"].Value?.ToString() ,
                    seleccionada.Cells["Cantidad"].Value?.ToString(),
                    seleccionada.Cells["Precio"].Value?.ToString(),
                    seleccionada.Cells["Año Edicion"].Value?.ToString(),
                    seleccionada.Cells["Genero"].Value?.ToString(),
                    seleccionada.Cells["Sello Discografico"].Value?.ToString(),
                    seleccionada.Cells["Interprete"].Value.ToString()
                    };

                    dataGridView2.Rows.Add(fila);
                }

            };

            }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Dispose();
        }
    }
}
