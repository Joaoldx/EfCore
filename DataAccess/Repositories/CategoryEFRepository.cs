using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Context;
using DomainModel.Entity;
using DomainService.Repositories;

namespace DataAccess.Repositories
{
    public class CategoryEFRepository : ICategoryRepository
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        public IEnumerable<Category> FindAll()
        {
            return _context.Categories.ToList();
        }

        public Category FindById(Guid categoryId){
            return _context.Categories.Find(categoryId);
        }
        public void Create(Category category)
        {
            if (category.Id == Guid.Empty){
                _context.Add(category);
            } else {
                var categoryToEdit = _context.Categories.First(c => c.Id == category.Id);
                categoryToEdit.Name = category.Name;
            }
            _context.SaveChanges();
        }

        public void Delete(Guid categoryId)
        {
            _context.Categories.Remove(FindById(categoryId));
            _context.SaveChanges();
        }

        public void Edit(Category category)
        {
            var categoryToEdit = FindById(category.Id);
            categoryToEdit.Name = category.Name;
            _context.SaveChanges();
        }
    }
}