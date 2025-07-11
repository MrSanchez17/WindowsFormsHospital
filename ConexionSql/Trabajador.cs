using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConexionSql
{
    public partial class Trabajador : Form
    {
        private readonly EmployeeServicio _employeeServicio = new EmployeeServicio();
        private readonly TrabajoServicio _jobServicio = new TrabajoServicio();
        private List<Job> _jobs = new List<Job>();

        public Trabajador()
        {
            InitializeComponent();
            CargarTrabajos();
            CargarEmpleados();
            buttonAdd.Click += BotonAñadir_Click;
    
        }

        private void CargarTrabajos()
        {
            _jobs = _jobServicio.GetAll(); // Asume que GetAll no lanza excepción inesperada
            comboBox1.DataSource = _jobs;
            comboBox1.DisplayMember = "job_title";
            comboBox1.ValueMember = "job_id";
        }

        private void CargarEmpleados()
        {
            var empleados = _employeeServicio.GetAll();
            dataGridView1.DataSource = empleados;
            dataGridView1.AutoResizeColumns();
        }

        private void BotonAñadir_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var nuevoEmpleado = new Employee
            {
                first_name = textBoxName.Text,
                last_name = textBoxSurname.Text,
                phone_number = textBoxPhone.Text,
                email = textBox3.Text,
                job_id = Convert.ToInt32(comboBox1.SelectedValue),
                salary = numericUpDown1.Value
            };

            _employeeServicio.Save(nuevoEmpleado);
            MessageBox.Show("Empleado añadido correctamente.");

            LimpiarCampos();
            CargarEmpleados();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un empleado para eliminar.");
                return;
            }

            int id = (int)dataGridView1.CurrentRow.Cells["employee_id"].Value;
            _employeeServicio.Delete(id);
            MessageBox.Show("Empleado eliminado.");

            CargarEmpleados();
        }

        private void BotonRefrescar_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                comboBox1.SelectedIndex == -1)
            {
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxPhone.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            numericUpDown1.Value = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var nuevoEmpleado = new Employee
            {
                first_name = textBoxName.Text,
                last_name = textBoxSurname.Text,
                phone_number = textBoxPhone.Text,
                email = textBox3.Text,
                job_id = Convert.ToInt32(comboBox1.SelectedValue),
                salary = numericUpDown1.Value,
                hire_date = DateTime.Now // Aquí podrías usar dateTimePicker1.Value si tienes uno
            };

            _employeeServicio.Save(nuevoEmpleado);
            MessageBox.Show("Empleado añadido correctamente.");

            LimpiarCampos();
            CargarEmpleados();
        }

    }
}
