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


        private void ToggleSubMenu(Panel subMenu)
        {
            subMenu.Visible = !subMenu.Visible;
        }


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

        #region MenuConfig

        private void menuConfig_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(panelSubMenuConfig);

        }

        #endregion
    }
}
