namespace Hospital
{
    public class Persona
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public eTipoPersonal Especialidad { get; set; }

        public Persona()
        {
            Especialidad = eTipoPersonal.Persona;
        }

        public Persona(string id, string nombre, string apellido, string telefono, string documento, string direccion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Documento = documento;
            this.Direccion = direccion;
            this.Especialidad = eTipoPersonal.Persona;
        }

        public override string ToString()
        {
            return $"#{Id} {Especialidad} - {Nombre} {Apellido}";
        }
    }
}
