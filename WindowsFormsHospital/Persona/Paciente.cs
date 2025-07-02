using System;
using Newtonsoft.Json;

namespace Hospital
{
    internal class Paciente : Persona
    {
        public string IdMedicoAsignado { get; set; }

        [JsonIgnore]
        public Medico MedicoAsignado { get; set; }
        public Paciente()
        {
            this.Especialidad = eTipoPersonal.Paciente;
        }
        public Paciente(string id, string name, string surname, string telefono, string documento, string direccion, string idMedicoAsignado)
            : base(id, name, surname, telefono, documento, direccion)
        {
            this.IdMedicoAsignado = idMedicoAsignado;
            this.Especialidad = eTipoPersonal.Paciente;
        }

        public override string ToString()
        {
            return $"#{Id} PACIENTE - {Nombre} {Apellido} (Médico: {MedicoAsignado?.Nombre} {MedicoAsignado?.Apellido})";
        }
    }
}
