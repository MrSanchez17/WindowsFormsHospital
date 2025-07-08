using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsHospital
{
    public partial class EliminarPaciente : Form
    {
        private List<Paciente> pacientes = new List<Paciente>();
        private readonly string rutaPacientes = @"C:\Users\ferna\Desktop\BootCamp\Mayo\WindowsFormsHospital\WindowsFormsHospital\bin\Debug\pacientes.json";

        public EliminarPaciente()
        {
            InitializeComponent();
            listBoxPacientes.MouseDoubleClick += listBoxPacientes_MouseDoubleClick;
            CargarPacientes();
        }

        private void CargarPacientes()
        {
            listBoxPacientes.Items.Clear();

            if (File.Exists(rutaPacientes))
            {
                string json = File.ReadAllText(rutaPacientes);
                pacientes = JsonConvert.DeserializeObject<List<Paciente>>(json) ?? new List<Paciente>();

                foreach (var paciente in pacientes)
                {
                    listBoxPacientes.Items.Add($"{paciente.Id} - {paciente.Nombre} {paciente.Apellido}");
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de pacientes.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxPacientes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un paciente para eliminar.");
                return;
            }

            // Obtener ID desde el texto del ListBox
            string seleccionado = listBoxPacientes.SelectedItem.ToString();
            string idSeleccionado = seleccionado.Split('-')[0].Trim();

            // Buscar y eliminar paciente
            var pacienteEliminar = pacientes.FirstOrDefault(p => p.Id == idSeleccionado);
            if (pacienteEliminar != null)
            {
                pacientes.Remove(pacienteEliminar);
                GuardarPacientes();
                CargarPacientes();
                MessageBox.Show("Paciente eliminado correctamente.");
            }
        }

        private void GuardarPacientes()
        {
            string json = JsonConvert.SerializeObject(pacientes, Formatting.Indented);
            File.WriteAllText(rutaPacientes, json);
        }

        private void listBoxPacientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxPacientes.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                listBoxPacientes.SelectedIndex = index;
                string seleccionado = listBoxPacientes.SelectedItem.ToString();
                string idSeleccionado = seleccionado.Split('-')[0].Trim();

                var pacienteEliminar = pacientes.FirstOrDefault(p => p.Id == idSeleccionado);
                if (pacienteEliminar != null)
                {
                    var confirmacion = MessageBox.Show(
                        $"¿Deseas eliminar al paciente {pacienteEliminar.Nombre} {pacienteEliminar.Apellido}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmacion == DialogResult.Yes)
                    {
                        pacientes.Remove(pacienteEliminar);
                        GuardarPacientes();
                        CargarPacientes();
                        MessageBox.Show("Paciente eliminado correctamente.");
                    }
                }
            }
        }

    }
}
