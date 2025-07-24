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


        //Abrir pantalllas de menu principal
        public void OpenChildForm(Form childForm)
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


        //Para abrir/cerrar subpantalllas de otras pantallas
        public void ToggleDetailForms(Form parentForm, Form childForm)
        {
            //cierra el form actual
            if (activeForm == parentForm)
            {

                //configura el form a abrir
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                //agrega el form al panel
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;

                //muestra el form
                parentForm.Visible = false;
                childForm.BringToFront();
                childForm.Show();


            }
            else if (activeForm == childForm)
            {
                parentForm.Visible = true;

                childForm.Close();
                activeForm = parentForm;
            }

        }



        //Para mostrar u ocultar submenu
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
        private void subMenuCompras_Click(object sender, EventArgs e)
        {
            //... codigo que abre la ventana de ventas
            OpenChildForm(new Pantallas.Pantallas_Transacciones.Pantallas_Compra.Compra());
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

        private void subMenuProductos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Pantallas.Pantallas_Transacciones.Producto());
        }

        #endregion


        #region Cerrar Sesion
        private void button1_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Login());
            panelMain.Visible = false;

        }
        #endregion



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void subMenuAgricultores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Pantallas.Pantallas_Socios.Agricultor());
        }

        private void subMenuFacturas_Click(object sender, EventArgs e)
        {
            PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Pantallas_Transacciones.Pantallas_Factura.Factura() );

        }
    }

}
