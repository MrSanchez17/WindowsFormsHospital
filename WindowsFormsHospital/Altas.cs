using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Hospital;

namespace WindowsFormsApp
{
    public partial class Altas : Form
    {
        private readonly string archivoMedicos = @"C:\Users\ferna\Desktop\BootCamp\Mayo\WindowsFormsHospital\WindowsFormsHospital\bin\Debug\medicos.json";
        private readonly string archivoPacientes = @"C:\Users\ferna\Desktop\BootCamp\Mayo\WindowsFormsHospital\WindowsFormsHospital\bin\Debug\pacientes.json";
        private readonly string archivoPersonal = @"C:\Users\ferna\Desktop\BootCamp\Mayo\WindowsFormsHospital\WindowsFormsHospital\bin\Debug\personal.json";

        private List<Persona> listaMedicos = new List<Persona>();
        private List<Paciente> listaPacientes = new List<Paciente>();
        private List<Persona> listaPersonal = new List<Persona>();

        public Altas()
        {
            InitializeComponent();

            comboBoxAltas.Items.Clear();
            comboBoxAltas.Items.AddRange(new string[] { "Medico", "Paciente", "Personal" });
            comboBoxAltas.SelectedIndex = 0;

            comboBoxMedico.Visible = false;
            labMedico.Visible = false;

            comboBoxAltas.SelectedIndexChanged += ComboBoxAltas_SelectedIndexChanged;
            butGuardarAlta.Click += butGuardarAlta_Click;

            CargarMedicos();
            CargarPacientes();
            CargarPersonal();

            ActualizarVistaSegunTipo();
        }

        private void ComboBoxAltas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarVistaSegunTipo();
        }

        private void ActualizarVistaSegunTipo()
        {
            string tipo = comboBoxAltas.SelectedItem.ToString();

            comboBoxMedico.Visible = tipo == "Paciente";
            labMedico.Visible = tipo == "Paciente";

            if (tipo == "Paciente")
                CargarMedicos();

            ActualizarEstadoGuardar();
        }

        private void ActualizarEstadoGuardar()
        {
            string tipo = comboBoxAltas.SelectedItem.ToString();

            if (tipo == "Paciente" && listaMedicos.Count == 0)
            {
                butGuardarAlta.Enabled = false;
                // Solo habilita o no el botón, sin mostrar mensaje
            }
            else
            {
                butGuardarAlta.Enabled = true;
            }
        }

        private void CargarMedicos()
        {
            if (File.Exists(archivoMedicos))
            {
                string json = File.ReadAllText(archivoMedicos);
                listaMedicos = JsonConvert.DeserializeObject<List<Persona>>(json) ?? new List<Persona>();
            }
            else
            {
                listaMedicos = new List<Persona>();
            }

            comboBoxMedico.Items.Clear();
            foreach (var m in listaMedicos)
                comboBoxMedico.Items.Add($"{m.Nombre} {m.Apellido}");

            if (comboBoxMedico.Items.Count > 0)
                comboBoxMedico.SelectedIndex = 0;
        }

        private void CargarPacientes()
        {
            if (File.Exists(archivoPacientes))
            {
                string json = File.ReadAllText(archivoPacientes);
                listaPacientes = JsonConvert.DeserializeObject<List<Paciente>>(json) ?? new List<Paciente>();
            }
            else
            {
                listaPacientes = new List<Paciente>();
            }

            // Después de cargar, asignar objeto MedicoAsignado a cada paciente
            foreach (var p in listaPacientes)
            {
                p.MedicoAsignado = listaMedicos.OfType<Medico>().FirstOrDefault(m => m.Id == p.IdMedicoAsignado);
            }
        }

        private void CargarPersonal()
        {
            if (File.Exists(archivoPersonal))
            {
                string json = File.ReadAllText(archivoPersonal);
                listaPersonal = JsonConvert.DeserializeObject<List<Persona>>(json) ?? new List<Persona>();
            }
            else
            {
                listaPersonal = new List<Persona>();
            }
        }

        private int ObtenerSiguienteIdMedico()
        {
            if (listaMedicos.Count == 0) return 1;
            return listaMedicos.Max(m => int.TryParse(m.Id, out int id) ? id : 0) + 1;
        }

        private int ObtenerSiguienteIdPaciente()
        {
            if (listaPacientes.Count == 0) return 1;
            return listaPacientes.Max(p => int.TryParse(p.Id, out int id) ? id : 0) + 1;
        }

        private int ObtenerSiguienteIdPersonal()
        {
            if (listaPersonal.Count == 0) return 1;
            return listaPersonal.Max(p => int.TryParse(p.Id, out int id) ? id : 0) + 1;
        }

        private void butGuardarAlta_Click(object sender, EventArgs e)
        {
            string tipo = comboBoxAltas.SelectedItem.ToString();

            Persona personaBase = new Persona
            {
                Nombre = textBoxName.Text.Trim(),
                Apellido = textBoxSurname.Text.Trim(),
                Telefono = textBoxTelefono.Text.Trim(),
                Direccion = textBox1.Text.Trim()
            };

            // Validar que nombre y apellido no estén vacíos
            if (string.IsNullOrWhiteSpace(personaBase.Nombre) || string.IsNullOrWhiteSpace(personaBase.Apellido))
            {
                return;
            }

            switch (tipo)
            {
                case "Medico":

                    Persona nuevoMedico = new Persona
                    {
                        Id = ObtenerSiguienteIdMedico().ToString(),
                        Nombre = personaBase.Nombre,
                        Apellido = personaBase.Apellido,
                        Telefono = personaBase.Telefono,
                        Direccion = personaBase.Direccion
                    };
                    listaMedicos.Add(nuevoMedico);
                    GuardarLista(listaMedicos, archivoMedicos);
                    MessageBox.Show("Médico guardado.");
                    break;

                case "Personal":

                    Persona nuevoPersonal = new Persona
                    {
                        Id = ObtenerSiguienteIdPersonal().ToString(),
                        Nombre = personaBase.Nombre,
                        Apellido = personaBase.Apellido,
                        Telefono = personaBase.Telefono,
                        Direccion = personaBase.Direccion
                    };
                    listaPersonal.Add(nuevoPersonal);
                    GuardarLista(listaPersonal, archivoPersonal);
                    MessageBox.Show("Personal guardado.");
                    break;

                case "Paciente":
                    if (comboBoxMedico.SelectedIndex < 0)
                    {
                        MessageBox.Show("Debes seleccionar un médico para el paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Persona medicoSeleccionado = listaMedicos[comboBoxMedico.SelectedIndex];

                    Paciente nuevoPaciente = new Paciente
                    {
                        Id = ObtenerSiguienteIdPaciente().ToString(),
                        Nombre = personaBase.Nombre,
                        Apellido = personaBase.Apellido,
                        Telefono = personaBase.Telefono,
                        Direccion = personaBase.Direccion,
                        IdMedicoAsignado = medicoSeleccionado.Id,
                        MedicoAsignado = medicoSeleccionado as Medico
                    };

                    listaPacientes.Add(nuevoPaciente);
                    GuardarLista(listaPacientes, archivoPacientes);
                    MessageBox.Show("Paciente guardado con médico asignado.");
                    break;
            }

            LimpiarCampos();
            if (tipo == "Medico") CargarMedicos();
        }

        private void GuardarLista<T>(List<T> lista, string archivo)
        {
            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
            File.WriteAllText(archivo, json);
        }

        private void LimpiarCampos()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxDNI.Clear();
            textBoxTelefono.Clear();
            textBox1.Clear();
            comboBoxMedico.SelectedIndex = -1;
        }
    }
}
