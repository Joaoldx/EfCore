using System;
using System.Linq;
using System.Threading.Tasks;
using DataAcess.Context;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class CategoryController : Controller
    {

        private ApplicationDbContext _context;
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _context = context;
        }

        public IActionResult Index() {
            var categories = _context.Categories.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Save(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(Category category){
            if (category.Id == Guid.Empty){
                _context.Categories.Add(category);
            } else {
                var categoryToEdit = _context.Categories.First(c => c.Id == category.Id);
                categoryToEdit.Name = category.Name;
            }
            await _context.SaveChangesAsync();
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