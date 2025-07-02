using System;
using System.Collections.Generic;

namespace Hospital
{
    internal class Medico : Persona
    {
        public List<Paciente> pacientes { get; set; } = new List<Paciente>();
        public List<Citas> citas { get; set; } = new List<Citas>();

        public Medico(){}

        public Medico(string id, string name, string surname, string telefono, string documento,string direccion) : 
            base(id, name, surname, telefono,documento, direccion)
        {
            this.Especialidad = eTipoPersonal.Medico;
        }

        public override string ToString()
        {
            return $"#{Id} MÉDICO - {Nombre} {Apellido} (Pacientes: {pacientes.Count})";
        }
    }
}
