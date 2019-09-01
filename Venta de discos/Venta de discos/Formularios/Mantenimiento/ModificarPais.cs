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
        public ModificarPais()
        {
            InitializeComponent();
            paisRepositorio = new PaisRepositorio();
            pais = paisRepositorio.ObtenerPais();
        }

        private void ModificarPais_Load(object sender, EventArgs e)
        {
            txtNombrePais = pais.Nombre;
            
            _id = pais.Id;
            
        }
    }
}
