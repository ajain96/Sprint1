using E_Commerce.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ECommerceDB1Context db;
        public ProductController(ECommerceDB1Context _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<TblProduct> GetProducts()
        {
            return db.TblProducts;
        }
    }
}