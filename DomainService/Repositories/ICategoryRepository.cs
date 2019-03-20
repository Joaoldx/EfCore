using System.Collections.Generic;
using DomainModel.Entity;

namespace DomainService.Repositories
{
    public interface ICategoryRepository
    {
        void Create(Category category);

        IEnumerable<Category> FindAll();
    }
}