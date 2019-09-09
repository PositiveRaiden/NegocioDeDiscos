using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_de_discos.Clases;
using Venta_de_discos.Repositorios;

namespace Venta_de_discos
{
    public partial class AgregarDisco : Form
    {
        InterpretesRepositorio interpretesRepositorio;
        GenerosRepositorio generosRepositorio;
        SelloRepositorio selloRepositorio;
        //FALTA CARGAR COMBO SELLOS
        public AgregarDisco()
        {
            InitializeComponent();
            interpretesRepositorio = new InterpretesRepositorio();
            generosRepositorio = new GenerosRepositorio();
            selloRepositorio = new SelloRepositorio();
        }

        private void AgregarDisco_Load(object sender, EventArgs e)
        {
            txtNombreAlbum.Focus();
            ActualizarComboInterprete();
            ActualizarComboGenero();
            ActualizarComboSello();
            

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Disco disc = new Disco();

            disc.nombreAlbum  = txtNombreAlbum.Text;
            disc.interprete = cmbInterprete.SelectedValue.ToString();
            disc.genero = cmbGenero.SelectedValue.ToString();
            disc.selloDiscografico = cmbSello.SelectedValue.ToString();
            disc.añoEdicion = int.Parse(txtAñoEdicion.Text);
            disc.precio = int.Parse(txtPrecio.Text);
            disc.cantidad = int.Parse(txtCantidad.Text);

            Disco disco = new Disco();
            disco.nombreAlbum = txtNombreAlbum.Text;

            if(!disco.NombreAlbumValido())
            {
                errorProvider1.SetError(txtNombreAlbum, "Error");
                txtNombreAlbum.Text = "";
                txtNombreAlbum.Focus();
                return;
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ActualizarComboInterprete()
        {
            var interpretes = interpretesRepositorio.ObtenerInterpretes();
            cmbInterprete.ValueMember = "Id";
            cmbInterprete.DisplayMember = "nombre";
            cmbInterprete.DataSource = interpretes;

        }

        private void ActualizarComboGenero()
        {
            var generos = generosRepositorio.ObtenerGenero();
            cmbGenero.ValueMember = "Id";
            cmbGenero.DisplayMember = "nombre";
            cmbGenero.DataSource = generos;

        }
        private void ActualizarComboSello()
        {
            var sellos = selloRepositorio.ObtenerSellos();

            cmbSello.DisplayMember = "nombre";
            cmbSello.ValueMember = "id";
            cmbSello.DataSource = sellos;

        }


    }
}
