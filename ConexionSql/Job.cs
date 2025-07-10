using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionSql
{
    public class Job
    {
        public int IdJob { get; set; }
        public string job_title { get; set; }
        public decimal min_salary { get; set; }
        public decimal max_salary { get; set; }

        public Job()
        {
        }
        public Job(int jobID, string jobTitle, decimal minSalary, decimal maxSalary)
        {
            IdJob = jobID;
            job_title = jobTitle;
            min_salary = minSalary;
            max_salary = maxSalary;
        }
        public override string ToString()
        {
            return $"{IdJob} - {job_title} (Min: {min_salary}, Max: {max_salary})";
        }
    }
}
