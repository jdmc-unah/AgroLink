﻿using AgroLink.Recursos;
using System.Data;

namespace AgroLink.Pantallas.Pantallas_Objetos
{
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();

        }

        #region Variables Globales

        Recursos_SQL recSQL = new Recursos.Recursos_SQL();   
        MetodosGlobales metGlobales = new Recursos.MetodosGlobales();

        #endregion

        #region Metodos

        //Metodo para activar o desactivar readonly en los campos de texto
        void ToggleReadOnlyTF(bool esSoloLectura)
        {
            this.textBox1.ReadOnly = esSoloLectura;
            this.textBox2.ReadOnly = esSoloLectura;
            this.textBox3.ReadOnly = esSoloLectura;
            this.textBox4.ReadOnly = esSoloLectura;
            this.textBox5.ReadOnly = esSoloLectura;
            this.richTextBox1.ReadOnly = esSoloLectura;
            this.button1.Visible = esSoloLectura;
            this.button2.Visible = !esSoloLectura;
            this.button3.Visible = !esSoloLectura;

            this.comboBox1.Enabled = !esSoloLectura;
            this.comboBox2.Enabled = !esSoloLectura;

        }


        void ToggleReadOnlyTable(bool esSoloLectura, string tabla)
        {
            if (tabla == "NumFiscal")
            {
                this.dataGridView1.ReadOnly = esSoloLectura;
                this.editarToolStripMenuItem.Visible = esSoloLectura;
                this.borrarToolStripMenuItem.Visible = esSoloLectura;
                this.guardarToolStripMenuItem.Visible = !esSoloLectura;
                this.cancelarToolStripMenuItem.Visible = !esSoloLectura;

                //   ToggleReadOnlyTable(true, "Impuesto");
            }


            if (tabla == "Impuesto")
            {
                this.dataGridView2.ReadOnly = esSoloLectura;
                this.editarToolStripMenuItem1.Visible = esSoloLectura;
                this.borrarToolStripMenuItem1.Visible = esSoloLectura;
                this.cancelarToolStripMenuItem1.Visible = !esSoloLectura;
                this.guardarToolStripMenuItem1.Visible = !esSoloLectura;

                //  ToggleReadOnlyTable(true, "NumFiscal");

            }

        }



        //Llena Comboboxes
        void LlenaDepto()
        {
            comboBox1.DataSource = recSQL.EjecutarVista("Pruebas.Departamento");  // Asignar el origen de datos
            comboBox1.DisplayMember = "Nombre";         // Columna que se mostrará
            comboBox1.ValueMember = "DepartamentoID";   // Valor interno que se usará

        }

        void LlenaMuni(int depto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                {"depto",  depto }
            };

            comboBox2.DataSource = recSQL.EjecutarSPDataTable("spTraeDeptoMunicipio", parametros);
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "MunicipioID";
        }


        //Trae los datos y Configura la tabla que va dentro del datagridview para que funcione la logica de los sp
        void LlenarTabla(DataGridView dataGridView, string vista)
        {
            DataTable dataTable = recSQL.EjecutarVista(vista);

            //configura la columna ID que siempre es la primera columna
            dataTable.Columns[0].AutoIncrement = false;   //se desativa el incremento temporalmente
            dataTable.Columns[0].DefaultValue = 0;        //se asigna un id 0 a las nuevas filas

            dataGridView.DataSource = dataTable;            //aqui se cargan los datos al datagridview

        }


        #endregion



        private void Empresa_Load(object sender, EventArgs e)
        {
            //Trae  Datos Empresa y llena campos de formulario
            DataRow valores = recSQL.EjecutarVista("vDatosEmpresa").Rows[0];

            this.textBox1.Text = valores["Nombre"].ToString();
            this.textBox2.Text = valores["RTN"].ToString();
            this.textBox3.Text = valores["Correo"].ToString();
            this.textBox4.Text = valores["Telefono"].ToString();
            this.textBox5.Text = valores["Colonia"].ToString();
            this.richTextBox1.Text = valores["Detalle"].ToString();


            //Trae Numeros Fiscales y llena datagridview 1
            LlenarTabla( this.dataGridView1 , "vNumerosFiscales");
            

            //Trae Impuesto y llena datagridview 2
            LlenarTabla( this.dataGridView2 , "vImpuesto");

   

            //Llena comboboxes de departamento y municipio
            LlenaDepto();
            comboBox1.SelectedValue = valores["Departamento"];

            LlenaMuni((int)comboBox1.SelectedValue);
            comboBox2.SelectedValue = valores["Municipio"];




        }




        #region Empresa


        //Boton Editar
        private void button1_Click(object sender, EventArgs e)
        {
            ToggleReadOnlyTF(false);
        }


        //Boton Aceptar
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (metGlobales.MensajeConfirmacion("Confirmar Actualización", "¿Desea guardar los cambios?"))
                {

                    Dictionary<string, object> parametros = new Dictionary<string, object>()
                {
                    {"nombre", this.textBox1.Text  },
                    {"rtn" ,   this.textBox2.Text  },
                    {"correo", this.textBox3.Text } ,
                    {"tel",    this.textBox4.Text } ,
                    {"col" ,   this.textBox5.Text } ,
                    {"det" ,   this.richTextBox1.Text },
                    {"muni",    this.comboBox2.SelectedValue }

                };

                    if (recSQL.EjecutarSPBool("spUpdateEmpresa", parametros))
                    {
                        MessageBox.Show("Se guardaron los cambios con éxito");
                        ToggleReadOnlyTF(true);
                        Empresa_Load(sender, e); //recarga el formulario para mostrar los nuevos datos
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los cambios no se han guardado debido a un error inesperado");
            }

        }


        //Boton Cancelar
        private void button3_Click(object sender, EventArgs e)
        {
            ToggleReadOnlyTF(true);
            
            Empresa_Load(sender, e); //recarga para deshacer los cambios
        }



        //Actualiza municipio en funcion del depto que se elige
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cuando se carga el formulario el valor del combobox es eso asi que da error sin esta validacion
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                LlenaMuni((int)comboBox1.SelectedValue);
            }
        }
        #endregion




        #region NumFiscal

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Toma el indice de la fila seleccionada y el valor seleccionado 
            int row = this.dataGridView1.CurrentRow.Index;
            int numFiscalID = (int)this.dataGridView1.Rows[row].Cells[0].Value;
            string? rangoIni = (string)this.dataGridView1.Rows[row].Cells[1].Value;

            //Confirma la decision del usuario y procede con lo demas
            if (metGlobales.MensajeConfirmacion("Confirmar", $"¿Esta seguro de borrar el Numero Fiscal con rango inicio: {rangoIni}?"))
            {
                //se crea diccionario para poner el paramemtro del id
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    {"id", numFiscalID },
                    {"tabla", "NumFiscal" }
                };

                //validar la ejecucion de spBorrarNumFiscal
                if (recSQL.EjecutarSPBool("spBorrarRegistro", parametros))
                {
                    MessageBox.Show($"Se borro el numero fiscal con el  rango inicio:  {rangoIni}");
                    LlenarTabla(this.dataGridView1, "vNumerosFiscales");

                }
                else
                {
                    MessageBox.Show($"Ocurrio un error al borrar el numero fiscal {numFiscalID}");
                }
            }
        }



        //boton de editar Numeros Fiscales con click derecho
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleReadOnlyTable(false, "NumFiscal");

            MessageBox.Show("Modo edicion para la tabla Numeros Fiscales Activado");

        }



        //Guardar cambios de edicion
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ejecuta sp, el metodo crear datatable es necesario para pasar la tabla como parametro
            DataTable? tablaNumFiscal = recSQL.EjecutarSPDataTable("spAddUpdateNumFiscal", "tabla", "TipoTablaNumFiscal", metGlobales.CrearDataTable(this.dataGridView1));

            
            if (tablaNumFiscal != null)
            {
                ToggleReadOnlyTable(true, "NumFiscal");     //cambia a modo solo lectura
               // this.dataGridView1.DataSource = tablaNumFiscal; //carga los datos en la tabla
                LlenarTabla(this.dataGridView1, "vNumerosFiscales");

                MessageBox.Show("Cambios guardados con éxito");

            }
            else
            {
                MessageBox.Show("Ocurrio un error inesperado");
            }
        }


        //esto es para evitar que este tirando error cada vez que se salga de la fila porque es molesto
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }


        private void cancelarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ToggleReadOnlyTable(true, "NumFiscal");

            LlenarTabla(this.dataGridView1, "vNumerosFiscales");

        }

        #endregion




        #region Impuesto

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            //Toma el indice de la fila seleccionada y el valor seleccionado 
            int row = this.dataGridView2.CurrentRow.Index;
            int impuestoID = (int)this.dataGridView2.Rows[row].Cells[0].Value;
            string nombre = (string) this.dataGridView2.Rows[row].Cells[1].Value;

            //Confirma la decision del usuario y procede con lo demas
            if (metGlobales.MensajeConfirmacion("Confirmar", $"¿Esta seguro de borrar {nombre} ?"))
            {
                //se crea diccionario para poner el paramemtro del id
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    {"id", impuestoID },
                    {"tabla", "Impuesto" }
                };

                //validar la ejecucion de spBorrarNumFiscal
                if (recSQL.EjecutarSPBool("spBorrarRegistro", parametros))
                {
                    MessageBox.Show($"Se borró {nombre}");
                    LlenarTabla(this.dataGridView2, "vImpuesto");

                }
                else
                {
                    MessageBox.Show($"Ocurrio un error al borrar el Impuesto {impuestoID}");
                }

            }

        }



        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToggleReadOnlyTable(false, "Impuesto");

            MessageBox.Show("Modo edicion para la tabla Impuesto Activado");

        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataTable? tablaImpuesto = recSQL.EjecutarSPDataTable("spAddUpdateImpuesto", "tabla", "TipoTablaImpuesto", metGlobales.CrearDataTable(this.dataGridView2));

            if (tablaImpuesto != null)
            {
                ToggleReadOnlyTable(true, "Impuesto");
                LlenarTabla(this.dataGridView2, "vImpuesto");

                MessageBox.Show("Cambios guardados con éxito");

            }
            else
            {
                MessageBox.Show("Ocurrio un error inesperado");
            }
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void cancelarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ToggleReadOnlyTable(true, "Impuesto");

            LlenarTabla(this.dataGridView2, "vImpuesto");

        }


        #endregion






        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
