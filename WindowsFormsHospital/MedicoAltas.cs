    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.IO;
    using Newtonsoft.Json;


    namespace WindowsFormsApp
    {
        public partial class MedicoAltas : Form
        {
        private readonly string archivoMedicos = @"C:\Users\ferna\Desktop\BootCamp\Mayo\WindowsFormsApp\WindowsFormsApp\bin\Debug\medicos.json";

        public MedicoAltas()
            {
                InitializeComponent();
            }

            private void MedicoAltas_Load(object sender, EventArgs e)
            {

            }

            private void butGuardarAlta_Click(object sender, EventArgs e)
            {
                string carpeta = Path.GetDirectoryName(archivoMedicos);
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }

                Medico nuevoMedico = new Medico
                {
                    Nombre = textBoxName.Text,
                    Apellido = textBoxSurname.Text,
                    DNI = textBoxDNI.Text,
                    Telefono = textBoxTelefono.Text,
                    Direccion = textBox1.Text
                };

                List<Medico> listaMedicos = new List<Medico>();

                if (File.Exists(archivoMedicos))
                {
                    string jsonExistente = File.ReadAllText(archivoMedicos);
                    listaMedicos = JsonConvert.DeserializeObject<List<Medico>>(jsonExistente) ?? new List<Medico>();
                }

                listaMedicos.Add(nuevoMedico);

                string jsonNuevo = JsonConvert.SerializeObject(listaMedicos, Formatting.Indented);
                File.WriteAllText(archivoMedicos, jsonNuevo);

                MessageBox.Show("Médico guardado correctamente.");
                LimpiarCampos();
            }

            private void LimpiarCampos()
            {
                textBoxName.Clear();
                textBoxSurname.Clear();
                textBoxDNI.Clear();
                textBoxTelefono.Clear();
                textBox1.Clear();
            }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MedicoAltas
            // 
            this.ClientSize = new System.Drawing.Size(593, 634);
            this.Name = "MedicoAltas";
            this.ResumeLayout(false);

        }
    }
    }
