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
    public partial class FormsMenuTransacciones : Form
    {
        public FormsMenuTransacciones()
        {
            InitializeComponent();
        }

        private void btn_nuevo_transventa_Click(object sender, EventArgs e)
        {
            Form formulario = new FormsTransaccionVenta();
            formulario.Show();
        }
        private void btn_nuevo_transST_Click(object sender, EventArgs e)
        {
            Form formulario = new FormsTransaccionServicioTecnico();
            formulario.Show();
        }
    }
}
