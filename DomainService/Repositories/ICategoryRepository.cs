using System.Collections.Generic;
using Domain.Entity;

namespace Domain.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
         void Create(Category category);

         IEnumerable<Category> FindAll();
    }
}