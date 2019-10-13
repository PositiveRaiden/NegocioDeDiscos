using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_de_discos.Formularios.Mantenimiento;
using Venta_de_discos.Formularios.Mantenimiento.abmSellos;
using Venta_de_discos.Formularios.Mantenimiento.Generos;
using Venta_de_discos.Repositorios;

namespace Venta_de_discos.Formularios.Discos
{
    public partial class ModificarDisco : Form
    {
        DiscosRepositorio discosRepositorio;
        InterpretesRepositorio interpretesRepositorio;
        SelloRepositorio selloRepositorio;
        GenerosRepositorio generosRepositorio;
        
        Disco disc;
        string _id;

        public ModificarDisco(string discoId)
        {
            InitializeComponent();
            discosRepositorio = new DiscosRepositorio();
            interpretesRepositorio = new InterpretesRepositorio();
            selloRepositorio = new SelloRepositorio();
            generosRepositorio = new GenerosRepositorio();

            disc = discosRepositorio.ObtenerDisco(discoId);
        }

        private void ModificarDisco_Load(object sender, EventArgs e)
        {
            txtNombreAlbum.Text = disc.nombreAlbum;
            cmbGenero.SelectedValue = disc.id_genero;
            cmbInterprete.SelectedValue = disc.id_interprete;
            cmbSello.SelectedValue = disc.id_selloDiscografico;
            txtPrecio.Text = disc.precio;
            txtCantidad.Text = disc.cantidad;
            txtAñoEdicion.Text = disc.añoEdicion;
            
            _id = disc.Id;
            ActualizarComboInterprete();
            ActualizarComboGenero();
            ActualizarComboSello();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var datosDisco = new Disco();
            datosDisco.nombreAlbum = txtNombreAlbum.Text.Trim();
            datosDisco.id_interprete = cmbInterprete.SelectedValue.ToString();
            datosDisco.id_genero = cmbGenero.SelectedValue.ToString();
            datosDisco.id_selloDiscografico = cmbSello.SelectedValue.ToString();
            datosDisco.añoEdicion = txtAñoEdicion.Text;
            datosDisco.precio = txtPrecio.Text;
            datosDisco.cantidad = "0";
            datosDisco.Id = _id;

            if (!datosDisco.NombreAlbumValido())
            {
                MessageBox.Show("Nombre Invalido!");
                //errorProvider1.SetError(txtNombreAlbum, "Error");
                txtNombreAlbum.Text = "";
                txtNombreAlbum.Focus();
                return;
            }
            if (datosDisco.nombreAlbum != disc.nombreAlbum)
            {
                if (datosDisco.NombreRepetido(datosDisco.nombreAlbum))
                {
                    MessageBox.Show("Nombre ya existe!");
                    txtNombreAlbum.Text = "";
                    txtNombreAlbum.Focus();
                    return;
                }
            }



            if (!datosDisco.AñoValido(datosDisco.añoEdicion))
            {
                MessageBox.Show("Año invalido!");
                txtAñoEdicion.Text = "";
                txtAñoEdicion.Focus();
                return;
            }
            if (!datosDisco.PrecioValido(datosDisco.precio))
            {
                MessageBox.Show("Precio invalido!");
                txtPrecio.Text = "";
                txtPrecio.Focus();
                return;
            }

            if (discosRepositorio.Editar(datosDisco))
            {
                MessageBox.Show("La edicion ha finalizado correctamente");
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoInterprete frm = new NuevoInterprete();
            frm.ShowDialog();
            ActualizarComboInterprete();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevoGenero frm = new NuevoGenero();
            frm.ShowDialog();
            ActualizarComboSello();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NuevoSello frm = new NuevoSello();
            frm.ShowDialog();
            ActualizarComboSello();
        }
    }
}
