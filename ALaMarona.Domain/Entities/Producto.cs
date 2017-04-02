﻿using Eg.Core;

namespace ALaMarona.Domain.Entities
{
    public class Producto: Entity<long>
    {
        public virtual string Codigo { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual int Talle { get; set; }
        public virtual Color Color { get; set; }
    }
}
