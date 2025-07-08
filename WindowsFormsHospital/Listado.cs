using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hospital;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsHospital
{
    public enum TipoListado
    {
        Medicos,
        Pacientes,
        Personal
    }

    public partial class Listado : Form
    {
        private readonly TipoListado tipo;

        private readonly string archivoMedicos = @"C:\Users\ferna\Desktop\BootCamp\Mayo\WindowsFormsHospital\WindowsFormsHospital\bin\Debug\medicos.json";
        private readonly string archivoPacientes = @"C:\Users\ferna\Desktop\BootCamp\Mayo\WindowsFormsHospital\WindowsFormsHospital\bin\Debug\pacientes.json";
        private readonly string archivoPersonal = @"C:\Users\ferna\Desktop\BootCamp\Mayo\WindowsFormsHospital\WindowsFormsHospital\bin\Debug\personal.json";

        public Listado(TipoListado tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.Load += Listado_Load;
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            listListadoInfo.Items.Clear();
            string ruta = "";

            switch (tipo)
            {
                case TipoListado.Medicos:
                    ruta = archivoMedicos;
                    break;
                case TipoListado.Pacientes:
                    ruta = archivoPacientes;
                    break;
                case TipoListado.Personal:
                    ruta = archivoPersonal;
                    break;
            }

            if (!File.Exists(ruta))
            {
                MessageBox.Show($"No se encontró el archivo: {ruta}");
                return;
            }

            string json = File.ReadAllText(ruta);

            switch (tipo)
            {
                case TipoListado.Medicos:
                case TipoListado.Personal:
                    var listaPersonas = JsonConvert.DeserializeObject<List<Persona>>(json);
                    foreach (var item in listaPersonas)
                        listListadoInfo.Items.Add($"{item.Id} - {item.Nombre} {item.Apellido} | Tel: {item.Telefono}");
                    break;

                case TipoListado.Pacientes:
                    var listaPacientes = JsonConvert.DeserializeObject<List<Paciente>>(json);
                    foreach (var item in listaPacientes)
                        listListadoInfo.Items.Add($"{item.Id} - {item.Nombre} {item.Apellido} | Médico ID: {item.IdMedicoAsignado}");
                    break;
            }
        }
    }
}
