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

            DataRow valores = recSQL.ejecutarVista("vDatosEmpresa").Rows[0];
            
            string nombre = valores[0].ToString();
            string rtn = valores[1].ToString();
            string correo = valores[2].ToString();
            string telefono = valores[3].ToString();
            string direccion = $"{valores["Detalle"].ToString()}, {valores["Colonia"].ToString()}, \n{valores["Municipio"].ToString()}, {valores["Departamento"].ToString()}   ";


            this.textBox1.Text = nombre;
            this.textBox2.Text = rtn;
            this.textBox3.Text = correo;
            this.textBox4.Text = telefono;
            this.richTextBox1.Text = direccion;



        }
    }
}
