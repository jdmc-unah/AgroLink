using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Pantallas.Pantallas_Objetos
{
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();

        }
        
        Recursos_SQL.Recursos_SQL recSQL = new Recursos_SQL.Recursos_SQL();
        

        private void Empresa_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("RTN");
            dt.Columns.Add("Correo");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Departamento");
            dt.Columns.Add("Municipio");
            dt.Columns.Add("Colonia");
            dt.Columns.Add("Detalle");


            DataRow fila = dt.NewRow();
            fila["Nombre"] = "José Martínez";
            fila["Telefono"] = "+50498765432";
            dt.Rows.Add(fila);





        }
    }
}
