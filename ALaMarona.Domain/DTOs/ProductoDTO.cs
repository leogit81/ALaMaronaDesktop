using Eg.Core.DTOs;

namespace ALaMarona.Domain.DTOs
{
    public class ProductoDTO : GenericDTO<long>
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Talle { get; set; }
    }
}