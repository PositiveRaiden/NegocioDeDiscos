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
    }
}
