using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModel.Entity;

namespace DomainService.Repositories
{
    public interface ICategoryRepository
    {

        Category FindById(Guid CategoryId);
        void Create(Category category);

        IEnumerable<Category> FindAll();

        void Delete(Guid categoryId);

        void Edit(Category category);
    }
}