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

namespace Venta_de_discos.Formularios.Mantenimiento.ajusteDiscos
{
    public partial class ModificarStock : Form
    {
        string _id;
        DiscosRepositorio discosRepositorio;
        AjustesRepositorio ajustesRepositorio;
        Disco disc;
        string canti;
        string descri;
        string fecha;

        public ModificarStock(string discoId)
        {
            InitializeComponent();
            discosRepositorio = new DiscosRepositorio();
            ajustesRepositorio = new AjustesRepositorio();
            disc = discosRepositorio.ObtenerDisco(discoId);

        }

        private void ModificarStock_Load(object sender, EventArgs e)
        {

            lblFecha.Text = "Fecha Actual: " + DateTime.Today.ToString("dd/MM/yyyy");
            lblNombre.Text = "Nombre Album: " + disc.nombreAlbum;
            lblPrecio.Text = "Precio: $" + disc.precio;
            lblCantidadActual.Text = "Cantidad actual: " + disc.cantidad;
            lblStockMinimo.Text = "Stock mínimo: " + disc.stock_minimo;
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            canti = txtCantidadNueva.Text.Trim();
            descri = txtDescripcion.Text;
            fecha = DateTime.Today.ToString("dd/MM/yyyy");
            if (!CantidadValida(canti))
            {
                MessageBox.Show("La cantidad ingresada no es valida.");
                txtCantidadNueva.Text = " ";
                txtCantidadNueva.Focus();
                return;
            }
            if (!DescripcionValida(descri))
            {
                MessageBox.Show("La descripcion ingresada no es valida.");
                txtDescripcion.Text = " ";
                txtDescripcion.Focus();
                return;
            }

            if (ajustesRepositorio.GuardarAjuste(disc.Id.ToString(), canti, fecha, descri))
            {
                MessageBox.Show("El ajuste se ha guardado con exito!");
                this.Dispose();
            }
            

        }

        public bool CantidadValida(string canti)
        {
            int number;
            int.TryParse(canti, out number);
            if (number >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DescripcionValida(string descri)
        {
            if (!string.IsNullOrEmpty(descri) && descri.Length < 51)
                return true;
            return false;
        }

        private void botonSalirMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
