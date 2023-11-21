using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_clase_MOANSO.Formularios
{
    public partial class FormsMenu : Form
    {
        //Campos
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        //Constructor
        public FormsMenu()
        {
            InitializeComponent();
            random = new Random();
        }
        //Metodos
        private Color SelectThemeColor()//Seleccionamos un color aleatorio de la lista
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)//Si el color ya fue seleccionado, selecionamos uno diferente
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnsender) {//Resaltar el boton que clickeamos

            /*Cuando le demos click pasara lo siguiente
             (1)Seleecionar un color aleatorio para el tema 
             (2)Cambiaremos el color de fondo 
             (3)Cambiaremos el color de fuente 
             (4)Cambiaremos el tamaño de la fuente*/
            if (btnsender != null) {
                if (currentButton != (Button)btnsender){
                    DisableButton(); 
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitulo.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()//Desactivar resaltado
        {
            foreach(Control previusBtn in panelMenu.Controls)
            {
                if (previusBtn.GetType() == typeof(Button)){
                    previusBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previusBtn.ForeColor = Color.Gainsboro;
                    previusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (childForm == null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;   
            this.pnlPanelDesktop.Controls.Add(childForm);
            this.pnlPanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTituloBaner.Text = childForm.Text;
        }

        private void btnFormularioProveedor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsMenuTransacciones(), sender);
        }

        private void btn_ventas_menu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsMantenedores(), sender);
        }

        private void btnServicioTecnico_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsConsultas(), sender);
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsMenuReportes(), sender);
        }

    }
}
