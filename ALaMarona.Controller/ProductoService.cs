﻿using ALaMarona.Domain.Entities;
using ALaMaronaDAL;
using NHibernate;

namespace ALaMarona.Service
{
    public class ProductoService
    {
        //TODO: Si el repositorio se inyecta no habria que guardar esta referencia y tampoco sería necesario el argumento del constructor
        private ISessionFactory sessionFactory { get; set; }

        protected ProductoRepository productoRepository;

        public ProductoService(ISessionFactory sessionFactory)
        {
            productoRepository = new ProductoRepository(sessionFactory);
        }
        
        public Producto GetById(long id)
        {
            return productoRepository.GetById(id);
        }

        public void Save(Producto producto)
        {
            productoRepository.Add(producto);
        }
    }
}
