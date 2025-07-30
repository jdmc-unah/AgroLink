using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroLink.Recursos
{
    internal class Recursos_SQL
    {

        string connectionString = "Server=3.128.144.165;Database=AgroLinkDB;User Id=jose.mejia;Password=JM20212030242;TrustServerCertificate=True";

        DataTable? dataTable;


        //metodo general para ejecutar procedimientos almacenados con recibir el nombre del sp y los parametros que ocupe
        //devuelve un datatable con los datos
        public DataTable? EjecutarSPDataTable(string nombreSP, Dictionary<string, object?>? parametros = null)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(nombreSP, connection))
                    {


                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        if (parametros != null) //valida si no lleva parametros entonces queda nulo y no agrega parametros
                        {
                            foreach (var param in parametros)
                            {
                                command.Parameters.AddWithValue($"@{param.Key}", param.Value ?? null);
                            }
                        }

                        connection.Open();

                        //lee el resultado del sp
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable = new DataTable(); //inicializa el datatable para borrar la data anterior que tenga
                            dataTable.Load(reader);

                            return dataTable;
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                foreach (SqlError error in ex.Errors)
                {
                    //imprime en pantalla el error que devuelve el sql
                    MessageBox.Show($"Error SQL: {error.Message}\nCódigo: {error.Number}");
                }

                return null;
            }

           
        }






        //Para usar tabla como parametro en un procedimiento almacenado
        //nombreParametro es el nombre de la tabla que va como parametro
        public DataTable? EjecutarSPDataTable(string nombreSP, string nombreParametro, string nombreTipoTabla, DataTable tabla, Dictionary<string, object?>? parametros = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(nombreSP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetro de entrada
                        SqlParameter parameter = command.Parameters.AddWithValue($"@{nombreParametro}", tabla ?? null);
                        parameter.SqlDbType = SqlDbType.Structured;
                        parameter.TypeName = nombreTipoTabla; //este es el tipo de tabla que se va a usar (usualmente se crea un tipo custom)

                        // Parámetros de entrada opcionales
                        if (parametros != null)
                        {
                            foreach (var param in parametros)
                            {
                                command.Parameters.AddWithValue($"@{param.Key}", param.Value ?? null);
                            }
                        }


                        connection.Open();


                        //lee el resultado del sp
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable = new DataTable(); //inicializa el datatable para borrar la data anterior que tenga
                            dataTable.Load(reader);

                            return dataTable;
                        }

                    }
                }

            }
            catch (SqlException ex)
             {
                foreach (SqlError error in ex.Errors)
                {
                    MessageBox.Show($"Error SQL: {error.Message}\nCódigo: {error.Number}");
                }

                return null;
            }
        }





        public bool EjecutarSPBool(string nombreSP, Dictionary<string, object>? parametros = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(nombreSP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        if (parametros != null)
                        {
                            foreach (var param in parametros)
                            {
                                command.Parameters.AddWithValue($"@{param.Key}", param.Value ?? null);
                            }
                        }

                        connection.Open();

                        //ejecuta el sp
                        int filas = command.ExecuteNonQuery();

                        return true;

                    }
                }
            }
            catch (SqlException ex)
            {
                foreach (SqlError error in ex.Errors)
                {
                    MessageBox.Show($"Error SQL: {error.Message}\nCódigo: {error.Number}");
                }

                return false;
            }
        }




            //tiene tabla como parametro
        public bool EjecutarSPBool(string nombreSP,  string paramTabla, string nombreTipoTabla, DataTable tabla, Dictionary<string, object>? parametros = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(nombreSP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetro de entrada
                        SqlParameter parameter = command.Parameters.AddWithValue($"@{paramTabla}", tabla ?? null);
                        parameter.SqlDbType = SqlDbType.Structured;
                        parameter.TypeName = nombreTipoTabla; //este es el tipo de tabla que se va a usar (usualmente se crea un tipo custom)


                        // Parámetros de entrada
                        if (parametros != null)
                        {
                            foreach (var param in parametros)
                            {
                                command.Parameters.AddWithValue($"@{param.Key}", param.Value ?? null);
                            }
                        }

                       
                        connection.Open();

                        //ejecuta el sp
                        command.ExecuteNonQuery();

                        return true;

                    }
                }

            }
            catch (SqlException ex)
            {
                foreach (SqlError error in ex.Errors)
                {
                    MessageBox.Show($"Error SQL: {error.Message}\nCódigo: {error.Number}");
                }

                return false;
            }
        }




        //Ejecutar Funciones con param tipo tabla
        public DataTable EjecutarFuncion(string nombreFuncion, string paramTabla, string nombreTipoTabla, DataTable tabla, Dictionary<string, object>? parametros = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                // Construye lista de argumentos, colocando primero el parámetro de tabla
                var argumentosFuncion = new List<string> { "@" + paramTabla };

                if (parametros != null)
                {
                    argumentosFuncion.AddRange(parametros.Keys.Select(k => "@" + k));
                }
                

                // Arma la consulta completa con los argumentos ordenados
                string cmdText = $"SELECT * FROM {nombreFuncion}({string.Join(", ", argumentosFuncion)})";



                using (SqlCommand command = new SqlCommand(cmdText, connection))
                //aqui habria que evaluar si se pone directamente asi la consulta o se modifica
                {
                    command.CommandType = CommandType.Text;

                    // Parámetros de entrada
                    if (parametros != null)
                    {
                        foreach (var param in parametros)
                        {
                            command.Parameters.AddWithValue($"@{param.Key}", param.Value ?? null);
                        }
                    }

                    // Parámetro de tipo tabla
                    SqlParameter parameter = command.Parameters.AddWithValue($"@{paramTabla}", tabla ?? null);
                    parameter.SqlDbType = SqlDbType.Structured;
                    parameter.TypeName = nombreTipoTabla; //este es el tipo de tabla que se va a usar (usualmente se crea un tipo custom)


                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable = new DataTable();

                        dataTable.Load(reader);

                        return dataTable;
                    }

                }
            }

        }


        public DataTable EjecutarFuncion(string nombreFuncion, Dictionary<string, object>? parametros = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand($"SELECT * FROM {nombreFuncion}({string.Join(", ", parametros.Keys.Select(k => "@" + k))})", connection))
                //aqui habria que evaluar si se pone directamente asi la consulta o se modifica
                {
                    command.CommandType = CommandType.Text;

                    // Parámetros de entrada
                    if (parametros != null)
                    {
                        foreach (var param in parametros)
                        {
                            command.Parameters.AddWithValue($"@{param.Key}", param.Value ?? null);
                        }
                    }

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable = new DataTable();

                        dataTable.Load(reader);

                        return dataTable;
                    }

                }
            }

        }




        //Ejecuta vistas
        public DataTable EjecutarVista(string nombreVista)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand($"SELECT * FROM {nombreVista}", connection))
                //aqui habria que evaluar si se pone directamente asi la consulta o se modifica
                {
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable = new DataTable();

                        dataTable.Load(reader);

                        return dataTable;
                    }

                }
            }

        }




























    }
}
