using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionSql
{
    public partial class Inserts : Form
    {
        public SqlConnection connection = new SqlConnection("Data Source=187.33.159.130,54321;" +
                          "Initial Catalog=;" + "Database = SanchezEmpleados;" +
                          "User ID=sa;" +
                          "Password=Sql#123456789;");
        public Inserts()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"INSERT INTO Job (job_title, min_salary, max_salary)
                         VALUES (@Trabajo, @SalarioMin, @SalarioMax)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Obtener valores del formulario
                    string trabajo = textBoxNombreTrabajo.Text.Trim();
                    decimal salarioMin = numericUpSalarioMin.Value;
                    decimal salarioMax = numericUpSalarioMax.Value;

                    // Validación simple
                    if (string.IsNullOrEmpty(trabajo))
                    {
                        MessageBox.Show("Por favor ingresa el nombre del trabajo.");
                        return;
                    }
                    if (salarioMin > salarioMax)
                    {
                        MessageBox.Show("El salario mínimo no puede ser mayor que el salario máximo.");
                        return;
                    }

                    command.Parameters.AddWithValue("@Trabajo", trabajo);
                    command.Parameters.AddWithValue("@SalarioMin", salarioMin);
                    command.Parameters.AddWithValue("@SalarioMax", salarioMax);

                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    int filasAfectadas = command.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados correctamente. Filas afectadas: " + filasAfectadas);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }

    }
}
