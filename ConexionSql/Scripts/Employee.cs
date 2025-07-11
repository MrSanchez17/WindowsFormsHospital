using System;

namespace ConexionSql
{
    public class Employee
    {
        public int employee_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone_number { get; set; }
        public int job_id { get; set; }
        public decimal salary { get; set; }
        public string email { get; set; }
        public DateTime hire_date { get; set; }


        public Employee() { }

        public Employee(int employee_id, string first_name, string last_name, string phone_number, int job_id, decimal salary, string email,DateTime hire_date)
        {
            this.employee_id = employee_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.phone_number = phone_number;
            this.job_id = job_id;
            this.salary = salary;
            this.email = email;
            this.hire_date = hire_date; 
        }

        public override string ToString()
        {
            return $"{employee_id} - {first_name} {last_name} - {email}";
        }
    }
}
