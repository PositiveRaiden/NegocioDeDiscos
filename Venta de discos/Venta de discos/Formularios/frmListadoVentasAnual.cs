﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_de_discos.Formularios
{
    public partial class frmListadoVentasAnual : Form
    {
        public frmListadoVentasAnual()
        {
            InitializeComponent();
        }

        private void frmListadoVentasAnual_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
