using Microsoft.AspNetCore.Mvc;
using MyBooksWeb.Data;
using MyBooksWeb.Models;

namespace MyBooksWeb.Controllers
{
    public class CategoryController : Controller
    {
        ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> categories = _db.Categories.ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
