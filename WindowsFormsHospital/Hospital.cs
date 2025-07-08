using System;
using System.Windows.Forms;
using WindowsFormsHospital;

namespace WindowsFormsApp
{
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
        }

        private void butAltaMedico_Click(object sender, EventArgs e)
        {
            Altas medicoAltasForm = new Altas();
            medicoAltasForm.ShowDialog();
        }

        private void butListarMedicos_Click(object sender, EventArgs e)
        {
            Listado listadoMedicos = new Listado(TipoListado.Medicos);
            listadoMedicos.ShowDialog();
        }

        private void butListarPersonal_Click(object sender, EventArgs e)
        {
            Listado listadoPersonal = new Listado(TipoListado.Personal);
            listadoPersonal.ShowDialog();
        }

        private void labListarPacientes_Click(object sender, EventArgs e)
        {
            Listado listadoHospital = new Listado(TipoListado.Pacientes);
            listadoHospital.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EliminarPaciente eliminarPacienteForm = new EliminarPaciente();
            eliminarPacienteForm.ShowDialog();

        }
    }
}
