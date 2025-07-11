using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ConexionSql
{
    public class EmployeeServicio
    {
        private DBConexion connection = new DBConexion();

        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM employees", connection.ObtenerConexion());
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = new Employee
                    {
                        employee_id = reader.IsDBNull(reader.GetOrdinal("employee_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("employee_id")),
                        first_name = reader.IsDBNull(reader.GetOrdinal("first_name")) ? null : reader.GetString(reader.GetOrdinal("first_name")),
                        last_name = reader.IsDBNull(reader.GetOrdinal("last_name")) ? null : reader.GetString(reader.GetOrdinal("last_name")),
                        phone_number = reader.IsDBNull(reader.GetOrdinal("phone_number")) ? null : reader.GetString(reader.GetOrdinal("phone_number")),
                        job_id = reader.IsDBNull(reader.GetOrdinal("job_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("job_id")),
                        salary = reader.IsDBNull(reader.GetOrdinal("salary")) ? 0 : reader.GetDecimal(reader.GetOrdinal("salary")),
                        email = reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString(reader.GetOrdinal("email")),
                        hire_date = reader.IsDBNull(reader.GetOrdinal("hire_date")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("hire_date"))
                    };

                    employees.Add(employee);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener los empleados: " + ex.Message);
            }
            finally
            {
                connection.CerrarConexion();
            }

            return employees;
        }

        public void Save(Employee employee)
        {
            string query = "INSERT INTO employees (first_name, last_name, phone_number, job_id, salary, email, hire_date) " +
                           "VALUES (@first_name, @last_name, @phone_number, @job_id, @salary, @email, @hire_date)";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection.ObtenerConexion());
                cmd.Parameters.AddWithValue("@first_name", employee.first_name);
                cmd.Parameters.AddWithValue("@last_name", employee.last_name);
                cmd.Parameters.AddWithValue("@phone_number", employee.phone_number);
                cmd.Parameters.AddWithValue("@job_id", employee.job_id);
                cmd.Parameters.AddWithValue("@salary", employee.salary);
                cmd.Parameters.AddWithValue("@email", employee.email);
                cmd.Parameters.AddWithValue("@hire_date", employee.hire_date); // se añade internamente

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al guardar el empleado: " + ex.Message);
            }
            finally
            {
                connection.CerrarConexion();
            }
        }

        public void Delete(int employeeId)
        {
            string query = "DELETE FROM employees WHERE employee_id = @id";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection.ObtenerConexion());
                cmd.Parameters.AddWithValue("@id", employeeId);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar el empleado: " + ex.Message);
            }
            finally
            {
                connection.CerrarConexion();
            }
        }

        public void Update(Employee employee)
        {
            string query = "UPDATE employees SET " +
                           "first_name = @first_name, last_name = @last_name, phone_number = @phone_number, " +
                           "job_id = @job_id, salary = @salary, email = @email " + // NOTA: no actualizamos hire_date
                           "WHERE employee_id = @employee_id";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection.ObtenerConexion());
                cmd.Parameters.AddWithValue("@first_name", employee.first_name);
                cmd.Parameters.AddWithValue("@last_name", employee.last_name);
                cmd.Parameters.AddWithValue("@phone_number", employee.phone_number);
                cmd.Parameters.AddWithValue("@job_id", employee.job_id);
                cmd.Parameters.AddWithValue("@salary", employee.salary);
                cmd.Parameters.AddWithValue("@email", employee.email);
                cmd.Parameters.AddWithValue("@employee_id", employee.employee_id);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar el empleado: " + ex.Message);
            }
            finally
            {
                connection.CerrarConexion();
            }
        }
    }
}
