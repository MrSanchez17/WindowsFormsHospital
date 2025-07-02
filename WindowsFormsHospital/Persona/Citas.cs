using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Citas
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public Medico MedicoAsignado { get; set; }
        public Paciente PacienteAsignado { get; set; }

        public Citas(int id, DateTime fechaHora, Medico medico, Paciente paciente)
        {
            Id = id;
            FechaHora = fechaHora;
            MedicoAsignado = medico;
            PacienteAsignado = paciente;
        }

        public override string ToString()
        {
            return $"Cita #{Id} - {FechaHora:g} | Médico: Dr. {MedicoAsignado.Nombre} {MedicoAsignado.Apellido} | Paciente: {PacienteAsignado.Nombre} {PacienteAsignado.Apellido}";
        }
    }
}
