using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaDatos;
using CapaEntidad;
using CapaLogica;

namespace Practica_clase_MOANSO
{
    public partial class FormsMantenedores : Form
    {
        bool accionSeleccionada = false;
        public FormsMantenedores()
        {
            InitializeComponent();
            listarCliente();
            gbx_datosprov.Enabled = false;
            txt_id_proveedor.Enabled = false;
        }
        #region mantenedor proveedor
        //Formulario de mantenedores
        public void listarCliente()
        {
            dgv_proveedor_mantenedor.DataSource = logCliente.Instancia.ListarCliente();
        }
        //Nuevo
        private void btn_nuevo_proveedor_Click_1(object sender, EventArgs e)
        {
            //Boolean
            accionSeleccionada = true;
            //
            gbx_datosprov.Enabled = true;
            btn_AddMod_proveedor.Visible = true;
            cbk_Estado_Cliente.Checked = true;
            btn_AddMod_proveedor.Text = "Agregar";
        }
        //Editar
        private void btn_editar_proveedor_Click_1(object sender, EventArgs e)
        {
            //boolean
            accionSeleccionada = false;
            //
            gbx_datosprov.Enabled = true;
            btn_AddMod_proveedor.Visible = true;
            btn_AddMod_proveedor.Text = "Modificar";
        }
        //Deshabilitar
        private void btn_deshabilitar_proveedor_Click_1(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.idCliente = int.Parse(txt_id_proveedor.Text.Trim());
                logCliente.Instancia.DeshabilitarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbx_datosprov.Enabled = false;
            listarCliente();
        }
        //Limpiar variables
        private void LimpiarVariables()
        {
            txt_Razon_Social.Text = "";
            txt_id_TipoCliente.Text = " ";
            txt_id_Ciudad.Text = " ";
        }

        //Botones del Groupbox
        //Agregar & Insertar
        private void btn_AddMod_proveedor_Click_1(object sender, EventArgs e)
        {
            if (accionSeleccionada)
            {
                try
                {
                    entCliente c = new entCliente();
                    c.razonSocial = txt_Razon_Social.Text.Trim();
                    c.Numero = int.Parse(txt_id_TipoCliente.Text.Trim());
                    c.fecRegCliente = dtPickerRegCliente.Value;
                    c.idCiudad = int.Parse(txt_id_Ciudad.Text.Trim());
                    c.estCliente = cbk_Estado_Cliente.Checked;
                    logCliente.Instancia.InsertaCliente(c);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.." + ex);
                }
                LimpiarVariables();
                gbx_datosprov.Enabled = false;
                btn_AddMod_proveedor.Text = "---";
                listarCliente();
            }
            else
            {
                try
                {
                    entCliente c = new entCliente();
                    c.idCliente = int.Parse(txt_id_proveedor.Text.Trim());
                    c.razonSocial = txt_Razon_Social.Text.Trim();
                    c.Numero = int.Parse(txt_id_TipoCliente.Text.Trim());
                    c.fecRegCliente = dtPickerRegCliente.Value;
                    c.idCiudad = int.Parse(txt_id_Ciudad.Text.Trim());
                    c.estCliente = cbk_Estado_Cliente.Checked;
                    logCliente.Instancia.EditaCliente(c);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.." + ex);
                }
                LimpiarVariables();
                gbx_datosprov.Enabled = false;
                btn_AddMod_proveedor.Text = "---";
                listarCliente();
            }
        }
        //Cancelar
        private void btn_cancelar_proveedor_Click_1(object sender, EventArgs e)
        {
            LimpiarVariables();
        }
        //DataGreedView_Evento_Cellclick
        private void dgv_proveedor_mantenedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgv_proveedor_mantenedor.Rows[e.RowIndex]; //

            txt_id_proveedor.Text = filaActual.Cells[0].Value.ToString();
            txt_Razon_Social.Text = filaActual.Cells[1].Value.ToString();
            txt_id_TipoCliente.Text = filaActual.Cells[2].Value.ToString();
            dtPickerRegCliente.Text = filaActual.Cells[3].Value.ToString();
            txt_id_Ciudad.Text = filaActual.Cells[4].Value.ToString();
            cbk_Estado_Cliente.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
        }
        #endregion mantenedor proveedor

    }
}
