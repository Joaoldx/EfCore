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

        [HttpGet]
        public IActionResult Edit(Guid id){
            //var category = _context.Categories.First(c => c.Id == id);
            return View("Save", _categoryRepository.FindById(id));
        }

        [HttpGet]
        public IActionResult Delete(Guid id) {
            _categoryRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}