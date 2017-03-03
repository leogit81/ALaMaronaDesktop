using ALaMarona.Service;
using ALaMaronaWebApi.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using NHibernate;

namespace ALaMaronaWebApi.Controllers
{
    [RoutePrefix("api/Producto")]
    public class ProductoController : ApiController
    {
        private ProductoService productoService;

        public ProductoController()
        {
            //TODO: resolver por injección de dependencias
            productoService = new ProductoService((ISessionFactory)HttpContext.Current.Application["SessionFactory"]);
        }

        [Route("")]
        // GET: api/Producto
        public IEnumerable<ProductoDTO> Get()
        {
            return productoService.GetAll().Select(p => new ProductoDTO()
            {
                Codigo = p.Codigo,
                Descripcion = p.Descripcion
            });
        }

        [Route("id")]
        // GET: api/Producto/5
        public ProductoDTO Get(string id)
        {
            return new ProductoDTO();
        }

        [Route("")]
        [HttpPost]
        // POST: api/Producto
        public void Post([FromBody]ProductoDTO producto)
        {
            var p = new ALaMarona.Domain.Entities.Producto() {
                Codigo = producto.Codigo,
                Descripcion = producto.Descripcion
            };

            productoService.Save(p);
        }

        [Route("{id}")]
        // PUT: api/Producto/5
        public void Put(int id, [FromBody]ProductoDTO producto)
        {
        }

        [Route("{id}")]
        // DELETE: api/Producto/5
        public void Delete(string id)
        {
        }
    }
}
