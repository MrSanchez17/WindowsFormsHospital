using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConexionSql
{
    public class DBConexion
    {
        private readonly string cadenaConexion = "Data Source=187.33.159.130,54321;" +
                                                 "Initial Catalog=SanchezEmpleados;" +
                                                 "User ID=sa;" +
                                                 "Password=Sql#123456789;";

        private SqlConnection conexion;

        public DBConexion()
        {
            var builder = new SqlConnectionStringBuilder(cadenaConexion);
            conexion = new SqlConnection(builder.ConnectionString);
        }

        public SqlConnection ObtenerConexion()
        {

            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    conexion.Open();
                }

                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("La conexión ya está abierta: " + ex.Message,
                                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    conexion.Close();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Error al cerrar la conexión: " + ex.Message,
                                    "Error de cierre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
