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
        public PantallaPrincipal()
        {
            InitializeComponent();
            
        }



        private void HideSubMenu()
        {
            if (panelSubMenuTrans.Visible)
            {
                panelSubMenuTrans.Visible = false;
            }
            if (panelSubMenuConfig.Visible)
            {
                panelSubMenuConfig.Visible = false;
            }

            //..agregar aqui todos los submenus de cada seccion

        }


        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }


        #region MenuTrans

        private void menuTrans_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuTrans);
        }

        private void subMenuVent_Click(object sender, EventArgs e)
        {
            //... codigo que abre la ventana de ventas
        }

        #endregion

        #region MenuConfig

        private void menuConfig_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuConfig);

        }

        #endregion
    }
}
