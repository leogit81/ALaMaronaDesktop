using ALaMarona.Domain.Entities;
using Eg.Core.Data.Impl;
using NHibernate;

namespace ALaMaronaDAL
{
    public class ProductoRepository: NHibernateRepository<Producto, long>
    {
        public ProductoRepository(ISessionFactory sessionFactory) : base(sessionFactory)
        {

        }

        public Producto GetById(long id)
        {
            return null;
        }
    }
}
