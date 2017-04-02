using Eg.Core;
using Iesi.Collections.Generic;

namespace ALaMarona.Domain.Entities
{
    public class Color : Entity<long>
    {
        public virtual string CodigoHexa { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual HashedSet<Producto> Productos { get; set; }
    }
}
