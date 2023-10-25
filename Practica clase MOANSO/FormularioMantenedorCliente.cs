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
    public partial class FormularioMantenedorCliente : Form
    {
        bool accionSeleccionada=false;
        public FormularioMantenedorCliente(){

            InitializeComponent();
            listarCliente();
            grupBoxDatos.Enabled = false;
            txtidCliente.Enabled = false;
        }

        public void listarCliente(){
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();  
        }
        //Nuevo
        private void btnNuevo_Click(object sender, EventArgs e){
            //Boolean
            accionSeleccionada = true;
            //
            grupBoxDatos.Enabled = true;    
            btnAddMod.Visible = true;
            cbkEstadoCliente.Checked = true;
            btnAddMod.Text = "Agregar";
        }
        //Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //boolean
            accionSeleccionada = false;
            //
            grupBoxDatos.Enabled = true;
            btnAddMod.Visible = true;
            btnAddMod.Text = "Modificar";

        }
        //Deshabilitar
        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.idCliente = int.Parse(txtidCliente.Text.Trim());
                logCliente.Instancia.DeshabilitarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCliente();
        }
        //Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Limpiar variables
        private void LimpiarVariables(){
            txtRazonSocial.Text = "";
            txtidTipoCliente.Text = " ";
            txtidCiudad.Text = " ";
        }

        //Botones del Groupbox
        //Agregar & Insertar
        private void btnAddMod_Click(object sender, EventArgs e){
            if(accionSeleccionada)
            {
                try
                {
                    entCliente c = new entCliente();
                    c.razonSocial = txtRazonSocial.Text.Trim();
                    c.idTipoCliente = int.Parse(txtidTipoCliente.Text.Trim());
                    c.fecRegCliente = dtPickerRegCliente.Value;
                    c.idCiudad = int.Parse(txtidCiudad.Text.Trim());
                    c.estCliente = cbkEstadoCliente.Checked;
                    logCliente.Instancia.InsertaCliente(c);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.." + ex);
                }
                LimpiarVariables();
                grupBoxDatos.Enabled = false;
                btnAddMod.Text = "---";
                listarCliente();
            }
            else
            {
                try
                {
                    entCliente c = new entCliente();
                    c.idCliente = int.Parse(txtidCliente.Text.Trim());
                    c.razonSocial = txtRazonSocial.Text.Trim();
                    c.idTipoCliente = int.Parse(txtidTipoCliente.Text.Trim());
                    c.fecRegCliente = dtPickerRegCliente.Value;
                    c.idCiudad = int.Parse(txtidCiudad.Text.Trim());
                    c.estCliente = cbkEstadoCliente.Checked;
                    logCliente.Instancia.EditaCliente(c);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.." + ex);
                }
                LimpiarVariables();
                grupBoxDatos.Enabled = false;
                btnAddMod.Text = "---";
                listarCliente();
            }
        }
        //Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        //DataGreedView
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex]; //

            txtidCliente.Text = filaActual.Cells[0].Value.ToString();
            txtRazonSocial.Text = filaActual.Cells[1].Value.ToString();
            txtidTipoCliente.Text = filaActual.Cells[2].Value.ToString();
            dtPickerRegCliente.Text = filaActual.Cells[3].Value.ToString();
            txtidCiudad.Text = filaActual.Cells[4].Value.ToString();
            cbkEstadoCliente.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
        }

    }
}
