using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ConexionSql
{
    public class TrabajoServicio
    {
        private DBConexion connection = new DBConexion();
        public List<Job> GetAll()
        {
            List<Job> jobs = new List<Job>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT* FROM jobs", connection.ObtenerConexion());
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Job job = new Job
                    {
                        job_id = reader.GetInt32(reader.GetOrdinal("job_id")),
                        job_title = reader.GetString(reader.GetOrdinal("job_title")),
                        min_salary = reader.IsDBNull(reader.GetOrdinal("min_salary")) ? 0 : reader.GetDecimal(reader.GetOrdinal("min_salary")),
                        max_salary = reader.IsDBNull(reader.GetOrdinal("max_salary")) ? 0 : reader.GetDecimal(reader.GetOrdinal("max_salary"))
                    };

                    jobs.Add(job);
                }
                connection.CerrarConexion();
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener los trabajos: " + ex.Message);
            }
            finally
            {
                connection.CerrarConexion();
            }

            return jobs;
        }
        public void Save(Job job)
        {
            string query = "INSERT INTO jobs (job_id, min_salary, max_salary) VALUES (@textBoxTrabajo, @numericUpDown1, @numericUpMaxSalario)";

            try
            {
                connection.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(query, connection.ObtenerConexion());
                {
                    cmd.Parameters.AddWithValue("@textBoxTrabajo", job.job_title);
                    cmd.Parameters.AddWithValue("@numericUpDown1", job.min_salary);
                    cmd.Parameters.AddWithValue("@numericUpMaxSalario", job.max_salary);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al guardar el trabajo: " + ex.Message);
            }
            finally
            {
                connection.CerrarConexion();
            }
        }
        public void Delete(int jobId)
        {
            string query = "DELETE FROM jobs WHERE job_id = @id";

            try
            {
                connection.ObtenerConexion();
                using (SqlCommand cmd = new SqlCommand(query, connection.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@id", jobId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar el trabajo: " + ex.Message);
            }
            finally
            {
                connection.CerrarConexion();
            }
        }
        public void Update(Job job)
        {
            string query = "UPDATE jobs SET job_id = @textBoxTrabajo, min_salary = @numericUpDown1, max_salary = @numericUpMaxSalario WHERE IdJob = @id";
            try
            {
                connection.ObtenerConexion();
                using (SqlCommand cmd = new SqlCommand(query, connection.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@textBoxTrabajo", job.job_title);
                    cmd.Parameters.AddWithValue("@numericUpDown1", job.min_salary);
                    cmd.Parameters.AddWithValue("@numericUpMaxSalario", job.max_salary);
                    cmd.Parameters.AddWithValue("@id", job.job_id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar el trabajo: " + ex.Message);
            }
            finally
            {
                connection.CerrarConexion();
            }
        }
    }
}
