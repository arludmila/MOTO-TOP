using Business;
using Contracts.DTOs.Entities;
using Contracts.Utils;
using Entities.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    //TODO: arreglar los PUT para que acepten el id y el dto en vez de la entidad...
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : BaseController<Category, CategoryDto>
    {
        public CategoriesController(GenericService<Category> service) : base(service)
        {
        }


    }
}
