using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_clase_MOANSO
{
    public partial class FormsMenuReportes : Form
    {
        public FormsMenuReportes()
        {
            InitializeComponent();
        }

        private void btn_nuevo_reportercotizacion_Click(object sender, EventArgs e)
        {
            Form formulario = new FormsReporteCotización();
            formulario.Show();
        }

        private void btn_nuevo_reporteingreso_Click(object sender, EventArgs e)
        {
            Form formulario = new FormsReporteIngreso();
            formulario.Show();
        }

        private void btn_nuevo_reportesalida_Click(object sender, EventArgs e)
        {
            Form formulario = new FormsReporteSalida();
            formulario.Show();
        }

        private void btn_nuevo_reporterpedidoproducto_Click(object sender, EventArgs e)
        {
            Form formulario = new FormsPedidoproducto();
            formulario.Show();
        }
    }
}
