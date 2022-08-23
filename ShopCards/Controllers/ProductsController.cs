using Microsoft.AspNetCore.Mvc;
using ShopCards.Database;

namespace ShopCards.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
