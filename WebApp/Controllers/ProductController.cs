using System;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Context;
using DomainModel.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

       /*  public ProductController(ApplicationDbContext context)
        {
            _context = context;
        } */

        [HttpGet]
        public IActionResult Index() {
            var product = _context.Products.ToList();
            return View(product);
        } 

        [HttpGet]
        public IActionResult Save(){
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(Product product){
        if (product.Id == Guid.Empty){
            _context.Products.Add(product);
        } else {
            var productToEdit = _context.Products.First(c => c.Id == product.Id);
            productToEdit.Name = product.Name;
            productToEdit.CategoryId = product.CategoryId;
        } 
        await _context.SaveChangesAsync();
        return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(Guid id){
            var product = _context.Products.First(p => p.Id == id);
            ViewBag.Categories = _context.Categories.ToList();
            return View("Save", product);
        }

        public async Task<IActionResult> Delete(Guid id) {
            var product = _context.Products.First(p => p.Id == id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}