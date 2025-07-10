using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroLink.Recursos
{
    public class MetodosGlobales
    {

        public bool MensajeConfirmacion(string titulo, string mensaje)
        {
            DialogResult resultado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                return true;

            }

            return false;
        }






        //Llenar data table
        public DataTable CrearDataTable(Dictionary<string, Type> columnas, DataGridView myDataGrid)
        {
            DataTable myDataTable = new DataTable();

            foreach (var columna in columnas)
            {
                myDataTable.Columns.Add(columna.Key, columna.Value);

            }

            // Ejemplo : myDataTable.Columns.Add("IdCliente", typeof(int));

            foreach (DataGridViewRow fila in myDataGrid.Rows)
            {
                if (!fila.IsNewRow)
                {
                    foreach (var columna in columnas)
                    {

                        if (columna.Value == typeof(int))
                        {
                            myDataTable.Rows.Add(
                                Convert.ToInt32(fila.Cells[columna.Key].Value)
                            );
                        }

                        if (columna.Value == typeof(string))
                        {
                            myDataTable.Rows.Add(
                                fila.Cells[columna.Key].Value.ToString()
                            );
                        }
                    }
                }
            }

            return myDataTable;
        }











    }
}
