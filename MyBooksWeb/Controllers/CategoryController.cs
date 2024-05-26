using Microsoft.AspNetCore.Mvc;
using MyBooksWeb.Data;

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
            var categories = _db.Categories.ToList();
            return View();
        }
    }
}
