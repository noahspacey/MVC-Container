using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prjICETASK4.Data;
using prjICETASK4.Models;

namespace prjICETASK4.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _dbContext.Products.ToListAsync();
            return View(products);
        }

        [HttpPost]
        public async Task<IActionResult> UploadProduct(string ProductName, int ProductPrice)
        {
            var products = new Products
            {
                ProductName = ProductName,
                ProductPrice = ProductPrice,
            };

            _dbContext.Products.Add(products);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");

        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
