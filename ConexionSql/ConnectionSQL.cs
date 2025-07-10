using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConexionSql
{
    public partial class ConnectionSQL : Form
    {
        public ConnectionSQL()
        {
            InitializeComponent();
            this.Load += buttonRefresh_Click;
            dataGridViewMostrar.CellEndEdit += dataGridViewMostrar_CellEndEdit;

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            TrabajoServicio servicio = new TrabajoServicio();
            List<Job> jobs = servicio.GetAll();
            dataGridViewMostrar.DataSource = jobs;
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {

            string titulo = textBoxTrabajo.Text;
            decimal minSalary = numericUpDown1.Value;
            decimal maxSalary = numericUpMaxSalario.Value;

            Job nuevoTrabajo = new Job
            {
                job_title = titulo,
                min_salary = minSalary,
                max_salary = maxSalary
            };

            TrabajoServicio servicio = new TrabajoServicio();
            servicio.Save(nuevoTrabajo);

            MessageBox.Show("Trabajo guardado correctamente.");
            buttonRefresh_Click(sender, e); // refresca la tabla

        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMostrar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
                return;
            }

            int jobId = ((Job)dataGridViewMostrar.SelectedRows[0].DataBoundItem).IdJob;

            var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este trabajo?",
                                                "Confirmar eliminación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                TrabajoServicio servicio = new TrabajoServicio();
                servicio.Delete(jobId);

                MessageBox.Show("Trabajo eliminado correctamente.");
                buttonRefresh_Click(sender, e);

            }
        }

        private void dataGridViewMostrar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMostrar.Rows[e.RowIndex].DataBoundItem is Job job)
            {
                // Validación opcional
                if (job.min_salary > job.max_salary)
                {
                    MessageBox.Show("El salario mínimo no puede ser mayor que el máximo.");
                    buttonRefresh_Click(null, null); 
                    return;
                }

                TrabajoServicio servicio = new TrabajoServicio();
                servicio.Update(job);
            }
        }
    }

}
