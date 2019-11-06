using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_de_discos.Formularios.Discos;

namespace Venta_de_discos
{
    public partial class BuscarDisco : Form
    {
        //agrego discos que no existen en el pedido que acabo de recibir
        DiscosRepositorio disc;

        public BuscarDisco()
        {
            InitializeComponent();
            disc = new DiscosRepositorio();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BuscarDisco_Load(object sender, EventArgs e)
        {

            CargarComboInterprete();
            CargarDiscos();
            cmbInterprete.Focus();
        }

        private void CargarComboInterprete()
        {
            var interpretes = disc.ObtenerInterprete();

            DataRow row = interpretes.NewRow();
            row["nombre"] = "Todos";
            row["Id"] = 0;
            interpretes.Rows.InsertAt(row, 0);

            cmbInterprete.DataSource = interpretes;
            cmbInterprete.ValueMember = "id";
            cmbInterprete.DisplayMember = "nombre";
        }
        private void CargarDiscos()
        {
            //dataGridView1.Rows.Clear();
            var discos = disc.ObtenerDiscos();
            dataGridView1.DataSource = discos;
            this.dataGridView1.Columns["id"].Visible = false;
            //var discos = disc.ObtenerDiscos().Rows;
            //foreach (DataRow disco in discos)
            //{
            //    if (disco.HasErrors)
            //        continue; // no corto el ciclo
            //    var fila = new string[] {
            //        disco.ItemArray[0].ToString(),
            //        disco.ItemArray[1].ToString(),
            //        disco.ItemArray[2].ToString(),
            //        disco.ItemArray[3].ToString(),
            //        disco.ItemArray[4].ToString(),
            //        disco.ItemArray[5].ToString(),
            //        disco.ItemArray[6].ToString(),
            //        disco.ItemArray[6].ToString()

            //    };

            //    dataGridView1.Rows.Add(fila);
            //}
        }

        private void btnBuscarDisco_Click(object sender, EventArgs e)
        {
            if (cmbInterprete.SelectedValue is null)
            {
                MessageBox.Show("Interprete no existe!");
                cmbInterprete.Focus();
                return;
            }

            if (cmbInterprete.SelectedValue.ToString() == "0")
            {
                CargarDiscos();
                return;
            }


            ActualizarDiscosSegunFiltroInterprete();
        }

        private void ActualizarDiscosSegunFiltroInterprete()
        {
            //dataGridView1.Rows.Clear();
            var valor = cmbInterprete.SelectedValue;
            var discos = disc.ObtenerDiscosPorFiltroInterprete(valor.ToString());
            dataGridView1.DataSource = discos;
            this.dataGridView1.Columns["id"].Visible = false;

        }

        private void btnAñadirDisco_Click(object sender, EventArgs e)
        {
            var ventana = new AgregarDisco();
            ventana.ShowDialog();
            CargarDiscos();

        }

        private void cmbInterprete_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                var id = fila.Cells[0].Value;

                var confirmacion = MessageBox.Show($"¿Esta seguro/a de eliminar a {nombre}?",
                    "Confirmar operacion",
                    MessageBoxButtons.YesNo);

                if (confirmacion.Equals(DialogResult.No))
                    return;
                //AGREGAR METODO RECORRO VENTAS Y PEDIDOS Y REVISO QUE EL DISCO NO ESTE ASOCIADO

                var intentos = disc.PodraEliminar(id.ToString());
                var cant = intentos.Rows.Count;
                if (cant >= 1)
                {
                    MessageBox.Show($"Usted no podra eliminar a {nombre}, ya que tiene " +
                        $"ventas y/o pedidos asociados a el.");
                    return;
                }
                if (disc.Eliminar(id.ToString()))
                {
                    MessageBox.Show($"Usted Elimino a {nombre}");
                    CargarDiscos();
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

                var ventana = new ModificarDisco(id.ToString());
                ventana.ShowDialog();
                CargarDiscos();
            }
        }
    }
}
