using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Pantallas
{
    public partial class PantallaPrincipal : Form
    {

        public static PantallaPrincipal pantallaPrincipal;

        public PantallaPrincipal()
        {
            InitializeComponent();
            pantallaPrincipal = this;
        }



        #region Propiedades
        private Form activeForm = null;


        #endregion


        #region Metodos

        private void ToggleSubMenu(Panel subMenu)
        {
            subMenu.Visible = !subMenu.Visible;
        }



        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

        }


        #endregion




        #region MenuTrans

        private void menuTrans_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(panelSubMenuTrans);
        }

        private void subMenuVent_Click(object sender, EventArgs e)
        {
            //... codigo que abre la ventana de ventas

        }

        #endregion



        #region Menu de Configuraciones



        private void menuConfig_Click_1(object sender, EventArgs e)
        {
            ToggleSubMenu(panelSubMenuConfig);

        }

        private void subMenuEmpresa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Pantallas.Pantallas_Objetos.Empresa());

        }
        #endregion



        #region Menu de Socios

        private void menuSocios_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(panelSubMenuSocios);

        }

        #endregion


        #region Menu de Productos

        private void menuProductos_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(panelSubMenuProductos);

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Login());


            //this.Close();
            panelMain.Visible = false;
        }
    }
}
