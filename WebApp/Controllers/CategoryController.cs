using System;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Repositories;
using DomainModel.Entity;
using DomainService.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        private static ICategoryRepository _categoryRepository = new CategoryEFRepository();

        public IActionResult Index() {
            return View(_categoryRepository.FindAll());
        }

        [HttpGet]
        public IActionResult Save(){
            return View();
        }

        [HttpPost]
        public IActionResult Save(Category category){
         
            _categoryRepository.Create(category);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid id){
            var category = _context.Categories.First(c => c.Id == id);
            return View("Save", category);
        }

        public async Task<IActionResult> Delete(Guid id) {
            var category = _context.Categories.First(c => c.Id == id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}