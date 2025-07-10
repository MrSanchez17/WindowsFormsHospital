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
                SqlCommand cmd = new SqlCommand("SELECT* FROM Job", connection.ObtenerConexion());
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Job job = new Job
                    {
                        IdJob = reader.GetInt32(reader.GetOrdinal("IdJob")),
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
    }
}
