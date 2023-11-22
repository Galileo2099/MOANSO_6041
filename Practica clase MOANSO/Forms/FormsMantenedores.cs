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
            gbx_datoscliente.Enabled = false;
            txt_id_cliente.Enabled = false;
        }


        #region mantenedor cliente


        //Formulario de mantenedores
        public void listarCliente()
        {
            dgv_cliente_mantenedor.DataSource = logCliente.Instancia.ListarCliente();
        }
        //Nuevo
        private void btn_nuevo_proveedor_Click_1(object sender, EventArgs e)
        {
            //Boolean
            accionSeleccionada = true;
            //
            gbx_datoscliente.Enabled = true;
            btn_AddMod_cliente.Visible = true;
            cbk_Estado_Cliente.Checked = true;
            btn_AddMod_cliente.Text = "Agregar";
        }
        //Editar
        private void btn_editar_proveedor_Click_1(object sender, EventArgs e)
        {
            //boolean
            accionSeleccionada = false;
            //
            gbx_datoscliente.Enabled = true;
            btn_AddMod_cliente.Visible = true;
            btn_AddMod_cliente.Text = "Modificar";
        }
        //Deshabilitar
        private void btn_deshabilitar_proveedor_Click_1(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.idCliente = int.Parse(txt_id_cliente.Text.Trim());
                logCliente.Instancia.DeshabilitarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbx_datoscliente.Enabled = false;
            listarCliente();
        }
        //Limpiar variables
        private void LimpiarVariables()
        {
            txt_Razon_Social.Text = "";
            txt_id_Tipocliente.Text = " ";
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
                    c.Numero = int.Parse(txt_id_Tipocliente.Text.Trim());
                    c.fecRegCliente = dtPickerRegCliente.Value;
                    //c.idCiudad = int.Parse(txt_id_Ciudad.Text.Trim());
                    c.estCliente = cbk_Estado_Cliente.Checked;
                    logCliente.Instancia.InsertaCliente(c);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.." + ex);
                }
                LimpiarVariables();
                gbx_datoscliente.Enabled = false;
                btn_AddMod_cliente.Text = "---";
                listarCliente();
            }
            else
            {
                try
                {
                    entCliente c = new entCliente();
                    c.idCliente = int.Parse(txt_id_cliente.Text.Trim());
                    c.razonSocial = txt_Razon_Social.Text.Trim();
                    c.Numero = int.Parse(txt_id_Tipocliente.Text.Trim());
                    c.fecRegCliente = dtPickerRegCliente.Value;
                    //c.idCiudad = int.Parse(txt_id_Ciudad.Text.Trim());
                    c.estCliente = cbk_Estado_Cliente.Checked;
                    logCliente.Instancia.EditaCliente(c);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.." + ex);
                }
                LimpiarVariables();
                gbx_datoscliente.Enabled = false;
                btn_AddMod_cliente.Text = "---";
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
            DataGridViewRow filaActual = dgv_cliente_mantenedor.Rows[e.RowIndex]; //

            txt_id_cliente.Text = filaActual.Cells[0].Value.ToString();
            txt_Razon_Social.Text = filaActual.Cells[1].Value.ToString();
            txt_id_Tipocliente.Text = filaActual.Cells[2].Value.ToString();
            dtPickerRegCliente.Text = filaActual.Cells[3].Value.ToString();
            //txt_id_Ciudad.Text = filaActual.Cells[4].Value.ToString();
            cbk_Estado_Cliente.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }
        #endregion mantenedor cliente

        #region mantenedor diagnostico

        // Método para listar diagnósticos
        private void ListarDiagnostico()
        {
            dgv_diagnostico_mantenedor.DataSource = logDiagnostico.Instancia.ListarDiagnostico();
        }

        private void btn_nuevodiagnostico_mantenedor_Click(object sender, EventArgs e)
        {
            // Boolean
        accionSeleccionada = true;

            // Habilitar controles 
            gbx_datosdiagnostico_mantenedor.Enabled = true;
            btn_addmoddiagnostico_mantenedor.Visible = true;
            ckb_estDiagnostico_mantenedor.Checked = true;
            btn_addmoddiagnostico_mantenedor.Text = "Agregar";

            // Limpiar variables
            LimpiarVariablesDiagnostico();
        }

        private void btn_editardiagnostico_mantenedor_Click(object sender, EventArgs e)
        {
            // Boolean
            accionSeleccionada = false;

            // Habilitar controles
            gbx_datosdiagnostico_mantenedor.Enabled = true;
            btn_addmoddiagnostico_mantenedor.Visible = true;
            btn_addmoddiagnostico_mantenedor.Text = "Modificar";

            // Limpiar variables
            LimpiarVariablesDiagnostico();
        }

        private void btn_deshabilitardiagnostico_mantenedor_Click(object sender, EventArgs e)
        {
            try
            {
                entDiagnostico diag = new entDiagnostico();
                diag.DiagnosticoID = int.Parse(txt_iddiagnostico_mantenedor.Text.Trim());
                logDiagnostico.Instancia.EliminaDiagnostico(diag);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // Limpiar variables y actualizar lista
            LimpiarVariablesDiagnostico();
            dgv_diagnostico_mantenedor.Enabled = false;
            ListarDiagnostico();
        }
        private void btn_addmoddiagnostico_mantenedor_Click(object sender, EventArgs e)
        {
            try
            {
                entDiagnostico diag = new entDiagnostico();
                diag.Desc_diagnostico = txt_descdiagnostico_mantenedor.Text.Trim();
                diag.Fecha_diagnostico = dtp_regisdiagnostico_mantenedor.Value;
                diag.ClienteID = int.Parse(txt_iddiagnostico_mantenedor.Text.ToString());
                // Ajustar según tu estructura c.Numero = int.Parse(txt_id_Tipocliente.Text.Trim());
                diag.TecnicoID = int.Parse(txt_idtecnico_mantenedor.Text.ToString()); 
                // Ajustar según tu estructura
                diag.estDiagnostico = ckb_estDiagnostico_mantenedor.Checked;

                if (accionSeleccionada)
                {
                    logDiagnostico.Instancia.InsertaDiagnostico(diag);
                }
                else
                {
                    diag.DiagnosticoID = int.Parse(txt_iddiagnostico_mantenedor.Text.Trim());
                    logDiagnostico.Instancia.EditaDiagnostico(diag);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // Limpiar variables y actualizar lista
            LimpiarVariablesDiagnostico();
            dgv_diagnostico_mantenedor.Enabled = false;
            btn_addmoddiagnostico_mantenedor.Text = "---";
            ListarDiagnostico();
        }

        private void btn_cancelardiagnostico_mantenedor_Click(object sender, EventArgs e)
        {
            LimpiarVariablesDiagnostico();
        }
        private void LimpiarVariablesDiagnostico()
        {
            txt_iddiagnostico_mantenedor.Text = "";
            txt_descdiagnostico_mantenedor.Text = "";
            dtp_regisdiagnostico_mantenedor.Value = DateTime.Now;
        }
        private void dgv_diagnostico_mantenedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgv_diagnostico_mantenedor.Rows[e.RowIndex];
            txt_iddiagnostico_mantenedor.Text = filaActual.Cells[0].Value.ToString();
            txt_descdiagnostico_mantenedor.Text = filaActual.Cells[1].Value.ToString();
            // Ajustar el índice según la estructura real de tu DataGridView
            dtp_regisdiagnostico_mantenedor.Value = DateTime.Parse(filaActual.Cells[3].Value.ToString());
            ckb_estDiagnostico_mantenedor.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }

        #endregion mantenedor diagnostico

        #region tecnico
        private void btn_nuevo_tecnico_Click(object sender, EventArgs e)
        {

        }

        private void btn_editar_tecnico_Click(object sender, EventArgs e)
        {

        }

        private void btn_deshabilitar_tecnico_Click(object sender, EventArgs e)
        {

        }

        private void btn_addmod_tecnico_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_tecnico_Click(object sender, EventArgs e)
        {

        }

        #endregion tecnico
    }
}
