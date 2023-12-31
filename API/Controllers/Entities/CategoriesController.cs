﻿using Business.Services;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    //TODO: arreglar los PUT para que acepten el id y el dto en vez de la entidad...
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : BaseController<Category, CategoryDto, int>
    {
        public CategoriesController(GenericService<Category, int> service) : base(service)
        {
        }


    }
}
