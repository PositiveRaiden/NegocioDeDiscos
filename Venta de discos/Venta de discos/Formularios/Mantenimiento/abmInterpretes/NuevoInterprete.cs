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

namespace Venta_de_discos.Formularios.Mantenimiento
{
    public partial class NuevoInterprete : Form
    {
        PaisRepositorio paisRepositorio;
        InterpretesRepositorio interpretesRepositorio;
        public NuevoInterprete()
        {
            InitializeComponent();
            paisRepositorio = new PaisRepositorio();
            interpretesRepositorio = new InterpretesRepositorio();
        }

        private void NuevoInterprete_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
            ActualizarComboPais();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarComboPais()
        {
            var paises = paisRepositorio.ObtenerPais();
            cmbPais.ValueMember = "Id";
            cmbPais.DisplayMember = "nombre";
            cmbPais.DataSource = paises;

            //AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            //foreach (DataRow row in paises.Rows)
            //{
            //    collection.Add(Convert.ToString(row["nombre"]));
            //}

            //cmbPais.AutoCompleteCustomSource = collection;
            //cmbPais.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cmbPais.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var interprete = new Interprete();
            interprete.Nombre = txtNombre.Text.Trim();
            interprete.Id_Pais = cmbPais.SelectedValue.ToString();

            if (!interprete.NombreValido())
            {
                MessageBox.Show("Nombre Invalido!");
                txtNombre.Text = "";
                txtNombre.Focus();
                return;
            }

            if(interprete.NombreRepetido(interprete.Nombre))
            {
                MessageBox.Show("Nombre ya existe!");
                txtNombre.Text = "";
                txtNombre.Focus();
                return;
            }
            if (!interprete.IdValido())
            {

                MessageBox.Show("Pais Invalido!");
                cmbPais.Focus();
                return;

            }

            if (interpretesRepositorio.Guardar(interprete))
            {
                MessageBox.Show("Se agrego interprete con exito!");
                this.Dispose();
            }






        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
