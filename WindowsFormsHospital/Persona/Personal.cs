using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Personal : Persona
    {
        public Personal() { }
        public Personal(string id, string name, string surname, string telefono, string documento, string direccion) :
            base(id, name, surname, telefono, documento,direccion)
        {
            this.Especialidad = eTipoPersonal.Personal;
        }

        public override string ToString()
        {
            return $"#{Id} PERSONAL - {Nombre} {Apellido}";
        }

    }
}
