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
using Venta_de_discos.Formularios.Mantenimiento.Generos;
using Venta_de_discos.Formularios.Mantenimiento.Barrios;
using Venta_de_discos.Formularios.Mantenimiento.abmCliente;
using Venta_de_discos.Formularios.Mantenimiento.abmSellos;
using Venta_de_discos.Formularios.Mantenimiento.ajusteDiscos;

namespace Venta_de_discos
{
    public partial class MenuMantenimiento : Form
    {
        public MenuMantenimiento()
        {
            InitializeComponent();
        }

        private void btnBuscarDisco_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarDisco_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVentaDeDiscos_Click(object sender, EventArgs e)
        {
            Interpretes frm = new Interpretes();
            frm.ShowDialog();
        }


        private void btnGeneros_Click_1(object sender, EventArgs e)
        {
            Generos frm = new Generos();
            frm.ShowDialog();
            //this.Hide();
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            Paises frm = new Paises();
            frm.ShowDialog();
        }

        private void btnBarrio_Click(object sender, EventArgs e)
        {
            Barrios frm = new Barrios();
            frm.ShowDialog();
        }

        private void btnSello_Click(object sender, EventArgs e)
        {
            Sellos frm = new Sellos();
            frm.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes();
            frm.ShowDialog();
        }

        private void btnAjuste_Click(object sender, EventArgs e)
        {
            AjustesDiscos frm = new AjustesDiscos();
            frm.ShowDialog();
        }
    }
}
