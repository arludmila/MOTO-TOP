using Business.Services;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : BaseController<Product, ProductDto>
    {
        public ProductsController(GenericService<Product> service) : base(service)
        {
        }
    }
}
