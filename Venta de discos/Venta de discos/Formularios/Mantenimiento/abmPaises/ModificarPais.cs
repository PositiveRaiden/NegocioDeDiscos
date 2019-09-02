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
    public partial class ModificarPais : Form
    {
        PaisRepositorio paisRepositorio;
        Pais pais;
        string _id;
        public ModificarPais(string IdPais)
        {
            InitializeComponent();
            paisRepositorio = new PaisRepositorio();
            pais = paisRepositorio.ObtenerPais(IdPais);
        }

        private void ModificarPais_Load(object sender, EventArgs e)
        {
            txtNombrePais.Text = pais.Nombre;
            
            _id = pais.Id;
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var datosPais = new Pais();
            datosPais.Nombre = txtNombrePais.Text.Trim();
            datosPais.Id = _id;


            if (!datosPais.NombreValido())
            {
                MessageBox.Show("Nombre Pais Invalido!");
                txtNombrePais.Text = " ";
                txtNombrePais.Focus();
                return;
            }

            if (paisRepositorio.Editar(datosPais))
            {
                MessageBox.Show("La edicion ha finalizado correctamente");
                this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            //probando
        }
    }
}
