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

namespace Venta_de_discos.Formularios.Nueva_Venta
{
    public partial class NuevaVenta : Form
    {
        VentasRepositorio VentasRepositorio = new VentasRepositorio();
        DiscosRepositorio discosRepositorio = new DiscosRepositorio();
        public NuevaVenta()
        {
            InitializeComponent();
        }


        private void NuevaVenta_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            LblFechaHoy.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void ActualizarGrilla()
        {
            var discos = discosRepositorio.ObtenerDiscos();
            dgvDiscos.DataSource = discos;
            this.dgvDiscos.Columns["id"].Visible = false;
            this.dgvDiscos.Columns["cantidad"].Visible = false;
            this.dgvDiscos.Columns["precio"].Visible = false;
            this.dgvDiscos.Columns["genero"].Visible = false;
            this.dgvDiscos.Columns["año edicion"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var discosAgregados = dgvVentas.Rows;
            var seleccionadas = dgvDiscos.SelectedRows;
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
                    "0",
                    seleccionada.Cells["Precio"].Value?.ToString(),
                    seleccionada.Cells["Año Edicion"].Value?.ToString(),
                    seleccionada.Cells["Genero"].Value?.ToString(),
                    seleccionada.Cells["Sello Discografico"].Value?.ToString(),
                    seleccionada.Cells["Interprete"].Value.ToString()
                    };

                    dgvVentas.Rows.Add(fila);
                }

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //if(MessageBox.Show("Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //    Dispose();
            if (MessageBox.Show("Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Dispose();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
