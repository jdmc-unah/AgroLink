using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Pantallas.Pantallas_Socios
{
    public partial class Agricultor : Form
    {
        public Agricultor()
        {
            InitializeComponent();
        }

        #region Variables Globales

        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();
        Recursos.MetodosGlobales metGlobales = new Recursos.MetodosGlobales();

        #endregion


        private void Agricultor_Load(object sender, EventArgs e)
        {
            this.TablaAgricultor.DataSource = recSQL.EjecutarVista("vTraerAgricultores");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>()
            {
                { "cod", TbBuscar.Text.Trim() }
            };

            TablaAgricultor.DataSource = recSQL.EjecutarSPDataTable("spBuscarAgricultor", parametros);

        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.TablaAgricultor.DataSource = recSQL.EjecutarVista("vTraerAgricultores");
        }


    }

}

