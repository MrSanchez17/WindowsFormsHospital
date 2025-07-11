namespace ConexionSql
{
    public class Job
    {
        public int job_id { get; set; }
        public string job_title { get; set; }
        public decimal min_salary { get; set; }
        public decimal max_salary { get; set; }

        public Job() { }

        public Job(int idJob, string job_title, decimal min_salary, decimal max_salary)
        {
            this.job_id = idJob;
            this.job_title = job_title;
            this.min_salary = min_salary;
            this.max_salary = max_salary;
        }

        public override string ToString()
        {
            return $"{job_id} - {job_title} (Min: {min_salary}, Max: {max_salary})";
        }
    }
}
