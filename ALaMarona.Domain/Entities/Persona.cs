using Eg.Core;

namespace ALaMarona.Domain.Entities
{
    public class Persona: Entity<long>
    {
        public virtual string Codigo { get; set; }
        public virtual string Nombre { get; set; }
        public virtual Direccion Direccion { get; set; }
    }
}
