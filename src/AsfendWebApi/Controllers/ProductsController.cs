using AsfendWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AsfendWebApi.Controllers
{
    public class ProductsController : ApiController
    {
        List<Product> _products = new List<Product>
        {
            new Product{Id = 1, ProductName = "Potatoes", Price = "120" },
            new Product{Id = 2, ProductName = "Cassava", Price = "350" },
            new Product { Id = 3, ProductName = "Sorghum", Price = "370"}
        };
        public IEnumerable<Product> Get()
        {
            return _products;
        }
        public void Post([FromBody]Product product)
        {
            _products.Add(product);
        }
        public void Put(int id, [FromBody]Product product)
        {
            _products[id] = product;
        }
        public void Delete(int id)
        {
            _products.RemoveAt(id);
        }
    }
}
