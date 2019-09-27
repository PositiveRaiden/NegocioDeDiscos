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
        DiscosRepositorio discosRepositorio;

        public AgregarDisco()
        {
            InitializeComponent();
            interpretesRepositorio = new InterpretesRepositorio();
            generosRepositorio = new GenerosRepositorio();
            selloRepositorio = new SelloRepositorio();
            discosRepositorio = new DiscosRepositorio();
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

            disc.nombreAlbum  = txtNombreAlbum.Text.Trim();
            disc.id_interprete = cmbInterprete.SelectedValue.ToString();
            disc.id_genero = cmbGenero.SelectedValue.ToString();
            disc.id_selloDiscografico = cmbSello.SelectedValue.ToString();
            disc.añoEdicion = txtAñoEdicion.Text;
            disc.precio = txtPrecio.Text;
            disc.cantidad = "0";

            if(!disc.NombreAlbumValido())
            {
                MessageBox.Show("Nombre Invalido!");
                //errorProvider1.SetError(txtNombreAlbum, "Error");
                txtNombreAlbum.Text = "";
                txtNombreAlbum.Focus();
                return;
            }

            if (disc.NombreRepetido(disc.nombreAlbum))
            {
                MessageBox.Show("Nombre ya existe!");
                txtNombreAlbum.Text = "";
                txtNombreAlbum.Focus();
                return;
            }


            if(!disc.AñoValido(disc.añoEdicion))
            {
                MessageBox.Show("Año invalido!");
                txtAñoEdicion.Text = "";
                txtAñoEdicion.Focus();
                return;
            }
            if (!disc.PrecioValido(disc.precio))
            {
                MessageBox.Show("Precio invalido!");
                txtPrecio.Text = "";
                txtPrecio.Focus();
                return;
            }
            if (discosRepositorio.Guardar(disc))
            {
                MessageBox.Show("Se agrego Disco con exito!");
                this.Dispose();
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
            var sellos = selloRepositorio.ObtenerSello();

            cmbSello.DisplayMember = "nombre";
            cmbSello.ValueMember = "id";
            cmbSello.DataSource = sellos;

        }


    }
}
