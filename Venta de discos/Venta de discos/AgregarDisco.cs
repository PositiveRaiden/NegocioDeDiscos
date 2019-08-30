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
    public partial class AgregarDisco : Form
    {
        public AgregarDisco()
        {
            InitializeComponent();
        }

        private void AgregarDisco_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            //string nombreAlbum  = txtNombreAlbum.Text;
            //string interprete = cmbInterprete.SelectedValue.ToString();
            //string genero = cmbGenero.SelectedValue.ToString();
            //string sello = cmbSello.SelectedValue.ToString();
            //int año = int.Parse(txtAñoEdicion.Text);
            //int precio = int.Parse(txtPrecio.Text);
            //int cantidad = int.Parse(txtCantidad.Text);

            //Disco disco = new Disco(interprete, nombreAlbum, interprete, sello, año,precio,cantidad);

            Disco disco = new Disco();
            disco.NombreAlbum = txtNombreAlbum.Text;

            if(disco.NombreAlbum is null)
            {
                errorProvider1.SetError(txtNombreAlbum, "Error");
            }


        }
    }
}
