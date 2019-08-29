using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_de_discos
{
    public partial class BuscarDisco : Form
    {
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
        }

        private void CargarComboInterprete()
        {
            var interpretes = disc.ObtenerInterprete();
            cmbInterprete.DataSource = interpretes;
            cmbInterprete.ValueMember = "id";
            cmbInterprete.DisplayMember = "nombre";
        }
        private void CargarDiscos()
        {
            //dataGridView1.Rows.Clear();
            var discos = disc.ObtenerDiscos();
            dataGridView1.DataSource = discos;
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

            ActualizarDiscosSegunFiltroInterprete();
        }

        private void ActualizarDiscosSegunFiltroInterprete()
        {
            //dataGridView1.Rows.Clear();
            var valor = cmbInterprete.SelectedValue;
            var discos = disc.ObtenerDiscosPorFiltroInterprete(valor.ToString());
            dataGridView1.DataSource = discos;

        }
    }
}
