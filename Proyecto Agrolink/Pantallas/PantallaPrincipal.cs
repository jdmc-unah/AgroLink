using Microsoft.Identity.Client;
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

        public static PantallaPrincipal instanciaPantPrincipal;

        public PantallaPrincipal()
        {
            
            InitializeComponent();
            OpenChildForm(new Login());
            instanciaPantPrincipal = this; //guarda la instancia del form de la pantalla principal

        }



        #region Propiedades
        private Form activeForm = null;

        #endregion


        #region Metodos

        //NO TOCAR

        private void ToggleSubMenu(Panel subMenu)
        {
            subMenu.Visible = !subMenu.Visible;
        }



        private void OpenChildForm(Form childForm)
        {
            //cierra el form actual
            if (activeForm != null) activeForm.Close(); 

            //configura el form a abrir
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            //agrega el form al panel
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            //muestra el form
            childForm.BringToFront();
            childForm.Show();

        }


        //este se usa en la pantalla de login 
        public void TogglePanelMain()
        {
            panelMain.Visible = !panelMain.Visible;
        }


        #endregion




        #region MenuTrans

        private void menuTrans_Click(object sender, EventArgs e)
        {
            //.. esto le permite abrir y cerrar las opciones de submenu
            ToggleSubMenu(panelSubMenuTrans);
        }

        private void subMenuVent_Click(object sender, EventArgs e)
        {
            //... codigo que abre la ventana de ventas
            OpenChildForm(new Pantallas.Pantallas_Transacciones.Venta());

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


        #region Cerrar Sesion
        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new Login());
            panelMain.Visible = false;
        }
        #endregion
    
    
    
    }

}
