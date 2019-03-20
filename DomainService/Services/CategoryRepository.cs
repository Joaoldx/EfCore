
using System.Collections.Generic;
using DataAccess.Context;
using DomainModel.Entity;
using DomainService.Repositories;

namespace DomainService.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        
        public CategoryRepository(ApplicationDbContext context)
        {
        }

        public void Create(Category category)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Category> FindAll()
        {
            throw new System.NotImplementedException();
        }
    }
}