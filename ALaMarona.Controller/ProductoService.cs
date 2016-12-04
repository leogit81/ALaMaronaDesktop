using ALaMarona.Domain.Entities;
using ALaMaronaDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALaMarona.Controller
{
    public class ProductoService
    {
        protected ProductoRepository productoRepository;

        public ProductoService()
        {

        }

        public Producto GetById(long id)
        {
            return productoRepository.GetById(id);
        }

        public void Save(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
