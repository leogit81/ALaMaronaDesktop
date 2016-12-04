using Eg.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALaMarona.Domain.Entities
{
    public class Producto: Entity<long>
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

    }
}
