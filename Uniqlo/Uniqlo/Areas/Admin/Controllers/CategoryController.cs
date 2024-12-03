using Microsoft.AspNetCore.Mvc;
using Uniqlo.DataAccess;
using Uniqlo.Models;
using Uniqlo.ViewModel.Category;

namespace Uniqlo.Areas.Admin.Controllers
{
    public class CategoryController(UniqloDbContext _sql) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryCreateVM cm)
        {
            if (ModelState.IsValid) return BadRequest();
            Category c = new Category
            {
                Name = cm.Name,
            };
            _sql.Categories.Add(c);
            _sql.SaveChanges();
            return View();
        }

        [HttpPost]
        public IActionResult Update(CategoryCreateVM cm)
        {
            if (ModelState.IsValid) return BadRequest();
            Category c = new Category
            {
                Name = cm.Name,
            };
            _sql.Categories.Add(c);
            _sql.SaveChanges();
            return View();
        }
    }
}
