using Contracts.DTOs.Entities;
using Data.Repositories;
using Data.Repositories.Entities;
using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Entities
{
    public class CategoryService : GenericService<Category, CategoryDto, int>
    {
        private readonly GenericRepository<Category, int> _repository;

        public CategoryService(GenericRepository<Category, int> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
